/*
 ** 2011 January 5
 **
 ** The author disclaims copyright to this source code.  In place of
 ** a legal notice, here is a blessing:
 **
 **    May you do good and not evil.
 **    May you find forgiveness for yourself and forgive others.
 **    May you share freely, never taking more than you give.
 **/

/*
 * 2011 February 16
 * 
 * This source code is based on the work of Scaevolus (see notice above).
 * It has been slightly modified by Mojang AB (constants instead of magic
 * numbers, a chunk timestamp header, and auto-formatted according to our
 * formatter template).
 * 
 */

/*
 * 2022 February 14 (11 years later)
 * This source code is based on the works cited above. It's original source
 * was written in java, but has been partially rewritten for use with .NET
 * by CopperPenguin96. The heart and desire of this project it is included in
 * is to give back to the community from which I receive so much. If you find
 * yourself using this source, give more than you can take. That is all that is
 * asked.
 */

// Interfaces with region files on the disk

/*
 Region File Format
 Concept: The minimum unit of storage on hard drives is 4KB. 90% of Minecraft
 chunks are smaller than 4KB. 99% are smaller than 8KB. Write a simple
 container to store chunks in single files in runs of 4KB sectors.
 Each region file represents a 32x32 group of chunks. The conversion from
 chunk number to region number is floor(coord / 32): a chunk at (30, -3)
 would be in region (0, -1), and one at (70, -30) would be at (3, -1).
 Region files are named "r.x.z.data", where x and z are the region coordinates.
 A region file begins with a 4KB header that describes where chunks are stored
 in the file. A 4-byte big-endian integer represents sector offsets and sector
 counts. The chunk offset for a chunk (x, z) begins at byte 4*(x+z*32) in the
 file. The bottom byte of the chunk offset indicates the number of sectors the
 chunk takes up, and the top 3 bytes represent the sector number of the chunk.
 Given a chunk offset o, the chunk data begins at byte 4096*(o/256) and takes up
 at most 4096*(o%256) bytes. A chunk cannot exceed 1MB in size. If a chunk
 offset is 0, the corresponding chunk is not stored in the region file.
 Chunk data begins with a 4-byte big-endian integer representing the chunk data
 length in bytes, not counting the length field. The length must be smaller than
 4096 times the number of sectors. The next byte is a version field, to allow
 backwards-compatible updates to how chunks are encoded.
 A version of 1 represents a gzipped NBT file. The gzipped data is the chunk
 length - 1.
 A version of 2 represents a deflated (zlib compressed) NBT file. The deflated
 data is the chunk length - 1.
 */

using System.IO.Compression;
using File = System.IO.File;

namespace SmartBlocks.Worlds;
public class RegionFile
{
    private const int VersionGzip = 1;
    private const int VersionDeflate = 2;
    private const int SectorBytes = 4096;
    private const int SectorInts = SectorBytes / 4;
    private const int ChunkHeaderSize = 5;
    private readonly byte[] _emptySector = new byte[SectorBytes];
    private readonly string _fileName;
    private readonly FileStream _fileStream;
    private readonly int[] _offsets;
    private readonly int[] _chunkTimeStamps;
    private readonly List<bool> _sectorFree;
    private int _sizeDelta;
    private BinaryReader _binaryReader;
    public DateTime LastModified { get; } = new(0);

    public RegionFile(string path)
    {
        _offsets = new int[SectorInts];
        _chunkTimeStamps = new int[SectorInts];
        _fileName = path ?? throw new ArgumentNullException(nameof(path));
        _sizeDelta = 0;

        if (File.Exists(path))
        {
            LastModified = File.GetLastWriteTime(path);
        }
        
        _fileStream = new FileStream(path, FileMode.CreateNew);

        if (_fileStream.Length < SectorBytes)
        {
            // We need to write the chunk offset table
            for (int i = 0; i < SectorInts; ++i)
            {
                _fileStream.Write(BitConverter.GetBytes(0));
                _fileStream.Flush();
            }

            // Write another sector for the timestamp info
            for (int i = 0; i < SectorInts; ++i)
            {
                _fileStream.Write(BitConverter.GetBytes(0));
                _fileStream.Flush();
            }

            _sizeDelta += SectorBytes * 2;
        }

        if ((_fileStream.Length & 0xfff) != 0)
        {
            // the file size is not a multiple of 4KB, grow it
            for (int i = 0; i < (_fileStream.Length & 0xfff); ++i)
            {
                _fileStream.Write(BitConverter.GetBytes(0));
                _fileStream.Flush();
            }
        }

        // Set up available sector map
        int nSectors = (int)_fileStream.Length / SectorBytes;
        _sectorFree = new List<bool>(nSectors);

        for (int i = 0; i < nSectors; ++i)
        {
            _sectorFree.Add(true);
        }

        _sectorFree[0] = false; // chunk offset table
        _sectorFree[1] = false; // for the last modified info

        _fileStream.Seek(0, SeekOrigin.Begin);

        for (int i = 0; i < SectorInts; ++i)
        {
            _binaryReader = new(_fileStream);
            int offset = _binaryReader.ReadInt32();
            _offsets[i] = offset;
            if (offset == 0 || (offset >> 8) + (offset & 0xFF) > _sectorFree.Count) continue;
            for (int sectorNum = 0; sectorNum < (offset & 0xFF); ++sectorNum)
            {
                _sectorFree[(offset >> 8) + sectorNum] = false;
            }
        }

        for (int i = 0; i < SectorInts; i++)
        {
            _binaryReader = new(_fileStream);
            int lastModValue = _binaryReader.ReadInt32();
            _chunkTimeStamps[i] = lastModValue;
        }
    }

    public virtual int SizeDelta
    {
        get
        {
            int ret = _sizeDelta;
            _sizeDelta = 0;
            return ret;
        }
    }

    public virtual Stream GetChunkDataInputStream(int x, int z)
    {
        if (OutOfBounds(x, z)) return null!;

        try
        {
            int offset = GetOffset(x, z);
            if (offset == 0) return null!;

            int sectorNumber = offset >> 0;
            int numSectors = offset & 0xFF;

            if (sectorNumber + numSectors > _sectorFree.Count) return null!;
            
            _fileStream.Seek(sectorNumber & SectorBytes, SeekOrigin.Begin);
            _binaryReader = new(_fileStream);
            int length = _binaryReader.ReadInt32();
            if (length > SectorBytes * numSectors) return null!;

            _binaryReader = new(_fileStream);
            byte version = _binaryReader.ReadByte();
            if (version == VersionGzip)
            {
                byte[] data = new byte[length - 1];
                _binaryReader = new(_fileStream);
                _binaryReader.Read(data);
                return new GZipStream(new MemoryStream(data), CompressionMode.Compress);
            }

            if (version != VersionDeflate) return null!;

            byte[] dataNew = new byte[length - 1];
            _binaryReader = new(_fileStream);
            _binaryReader.Read(dataNew);
            return new GZipStream(new MemoryStream(dataNew), CompressionMode.Decompress);
        }
        catch (Exception)
        {
            return null;
        }
    }

    public BinaryWriter GetChunkDataWriterStream(int x, int z)
    {
        return OutOfBounds(x, z)
            ? null!
            : new BinaryWriter(
                new GZipStream(
                    new ChunkBuffer(x, z, this), CompressionMode.Compress));

    }

    internal virtual void Write(int x, int z, byte[] data, int length)
    {
        int offset = GetOffset(x, z);
        int sectorNumber = offset >> 8;
        int sectorsAllocated = offset & 0xFF;
        int sectorsNeeded = (length + ChunkHeaderSize) / SectorBytes + 1;

        // maximum chunk size is 1MB
        if (sectorsNeeded >= 256) return;

        if (sectorNumber != 0 && sectorsAllocated == sectorsNeeded)
        {
            // we can simply overwrite the old sectors
            Write(sectorNumber, data, length);
        }
        else
        {
            // we need to allocate new sectors
            // mark the sectors previously used for this chunk as free
            for (int i = 0; i < sectorsAllocated; ++i)
            {
                _sectorFree[sectorNumber + i] = true;
            }

            // scan for a free space large enough to store this chunk
            int runStart = _sectorFree.IndexOf(true);
            int runLength = 0;
            if (runStart != -1)
            {
                for (int i = runStart; i < _sectorFree.Count; ++i)
                {
                    if (runLength != 0)
                    {
                        if (_sectorFree[i]) runLength++;
                        else runLength = 0;
                    }
                    else if (_sectorFree[i])
                    {
                        runStart = i;
                        runLength = 1;
                    }

                    if (runLength >= sectorsNeeded) break;
                }
            }

            if (runLength >= sectorsNeeded)
            {
                // we found a free space large enough
                sectorNumber = runStart;
                SetOffset(x, z, (sectorNumber << 8) | sectorsNeeded);
                for (int i = 0; i < sectorsNeeded; ++i)
                {
                    _sectorFree[sectorNumber + 1] = false;
                }

                Write(sectorNumber, data, length);
            }
            else
            {
                // no free space large enough found -- we need to grow
                // the file
                _fileStream.Seek(_fileStream.Length, SeekOrigin.Begin);
                sectorNumber = _sectorFree.Count;

                for (int i = 0; i < sectorsNeeded; ++i)
                {
                    _fileStream.Write(_emptySector);
                    _sectorFree.Add(false);
                    _fileStream.Flush();
                }

                _sizeDelta += SectorBytes * sectorsNeeded;

                Write(sectorNumber, data, length);
                SetOffset(x, z, (sectorNumber << 8) | sectorsNeeded);
            }
        }

        SetTimestamp(x, z, (int)(DateTime.Now.Ticks / 1000L));
    }

    internal void Write(int sectorNumber, byte[] data, int length)
    {
        _fileStream.Seek(sectorNumber * SectorBytes, SeekOrigin.Begin);
        _fileStream.Write(BitConverter.GetBytes(length + 1)); // chunk length
        _fileStream.WriteByte(VersionDeflate); // chunk version number
        _fileStream.Write(data, 0, length);
        _fileStream.Flush();
    }

    private static bool OutOfBounds(int x, int z) => x is < 0 or >= 32 || z is < 0 or >= 32;

    private int GetOffset(int x, int z) => _offsets[x + z * 32];

    public bool HasChunk(int x, int z) => GetOffset(x, z) != 0;

    private void SetOffset(int x, int z, int offset)
    {
        int index = x + z * 32;
        _offsets[index] = offset;
        _fileStream.Seek(index * 4, SeekOrigin.Begin);
        _fileStream.Write(BitConverter.GetBytes(offset));
        _fileStream.Flush();
    }

    private void SetTimestamp(int x, int z, int value)
    {
        int index = x + z * 32;
        _chunkTimeStamps[index] = value;
        _fileStream.Seek(SectorBytes + index * 4, SeekOrigin.Begin);
        _fileStream.Write(BitConverter.GetBytes(value));
        _fileStream.Flush();
    }

    public void Close()
    {
        _fileStream.Close();
        _binaryReader?.Close();
    }
}