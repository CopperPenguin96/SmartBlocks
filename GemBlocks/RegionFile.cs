using System;
using System.Collections.Generic;
using System.IO;
using ICSharpCode.SharpZipLib.GZip;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

/*
 * 2011 January 5
 * The author disclaims copyright to this source code. In place of
 * a legal notice, here is a blessing:
 *
 *  May you do good and not evil.
 *  May you find forgiveness for yourself and forgive others.
 *  May you share freely, never taking more than you give.
 *
 * 2011 February 16
 *
 * This source code is based on the work of MorbZ who based his/her
 * work on Scaevolus (See notice above). It has been slightly modified
 * by MojangAB (constants instead of magic numbers, a chunk timepstamp
 * header, and auto-formatted according to our formatter template).
 *
 * 2019 November 11
 *
 * The code was hence converted to C# by apotter96 and added the above legal
 * notice and information about the region file format for the use of
 * those who wish to continue their work on .NET. It is with great gratitude
 * that apotter96 has for the original authors of this work for making it
 * public. I hope for the best. Live, laugh, love, MINECRAFT!
 */

/*
 * Region File Format
 *
 * Concept: The minimum unit of storage on hard drives if 4KB. 90% of Minecraft
 * chunks are smaller than 4KB. 99% are smaller than 8KB. Write a simple
 * container to store chunks in single files in runs of 4KB sectors.
 *
 * Each region represents 32x32 group of chunks. The conversion from
 * chunk number to region number is floor(coord / 32): a chunk a (30, 03)
 * would be in region (0, -1), and one at (70, -30) would be at (3, -1).
 * Region files are named r.x.z.data where x and z are the region coordinates.
 *
 * A region file begins with a 4KB header that describes where chunks are stored
 * in the file. A 4-byte big-endian integer represents sector offsets and sector
 * counts. The chunk offset for a chunk (x, z) begins at byte 4*(x+z*32) in the
 * file. The bottom byte of the chunk offset indicates the number of sectors the
 * chunk takes up, and the top 3 bytes represent the sector number of the chunk.
 * Given a a chunk offset o, the chunk data begins at byte 4096*(o/256) and takes up
 * at most 4096*(o%256) bytes. A chunk cannot exceed 1MB in size. If a chunk
 * offset is 0, the corresponding chunk is not stored in the region file.
 *
 * Chunk dat abegins with a 4-byte big-endian integer representing the chunk data
 * length in bytes, not counting the length field. The length must be smaller than
 * 4096 times the number of sectors. The next byte is a version field, to allow
 * backwards-compatible updates to how chunks are encoded.
 *
 * A version of 1 represents a gzipped NBT file. The gzipped data is the chunk
 * length - 1.
 *
 * A version of 2 represents a deflated (zlib compressed) NBT file. The deflated
 * data is the chunk length - 1.
 */
namespace GemBlocks
{
    public class RegionFile
    {
        private const int VersionGZip = 1;
        private const int VersionDeflate = 2;

        private const int SectorBytes = 4096;
        private const int SectorInts = SectorBytes / 4;

        private const int ChunkHeaderSize = 5;
        private readonly byte[] _emptySector = new byte[4096];

        private readonly string _fileName;
        public string File1 { get; }
        private readonly int[] _offsets;
        private readonly int[] _chunkTimeStamps;
        private readonly List<bool> _sectorFree;
        private int _sizeDelta;
        private readonly long _lastModified = 0;

        public RegionFile(string path)
        {
            _offsets = new int[SectorInts];
            _chunkTimeStamps = new int[SectorInts];
            _fileName = path;
            Console.WriteLine("REGION LOAD " + _fileName);
            _sizeDelta = 0;
            
            try
            {
                if (File.Exists(path))
                {
                    _lastModified = File.GetLastWriteTime(path).Millisecond;
                }

                File1 = path;
                int conts = File.ReadAllBytes(path).Length;
                if (conts < SectorBytes)
                {
                    // We need to write chunk offset table
                    for (int i = 0; i < SectorInts; ++i) // ++i thats new 0.0
                    {
                        WriteInt(0);
                    }

                    // write another sector for the timestamp info
                    for (int i = 0; i < SectorInts; ++i)
                    {
                        WriteInt(0);
                    }

                    _sizeDelta += SectorBytes * 2;
                }

                if ((conts & 0xfff) != 0)
                {
                    // the file size is not a multiple of 4KB, grow it
                    for (int i = 0; i < (conts & 0xfff); ++i)
                    {
                        WriteByte(0);
                    }
                }

                // set up the available sector map
                int nSectors = conts / SectorBytes;
                _sectorFree = new List<bool>(nSectors);

                for (int i = 0; i < nSectors; ++i)
                {
                    _sectorFree.Add(true);
                }

                _sectorFree[0] = false; // chunk offset table
                _sectorFree[1] = false; // for the last modified info
                _fout.Seek(0, SeekOrigin.Begin);
                using (var bReader = new BinaryReader(_fout))
                {
                    for (int i = 0; i < SectorInts; ++i)
                    {
                        int offset = bReader.ReadInt32();
                        _offsets[i] = offset;
                        if (offset == 0 || (offset >> 8) + (offset & 0xFF) > _sectorFree.Count) continue;
                        for (int sectorNum = 0; sectorNum < (offset & 0xFF); ++sectorNum)
                        {
                            _sectorFree[(offset >> 8) + sectorNum] = false;
                        }
                    }

                    for (int i = 0; i < SectorInts; ++i)
                    {
                        int lastModValue = bReader.ReadInt32();
                        _chunkTimeStamps[i] = lastModValue;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public long LastModified()
        {
            return _lastModified;
        }

        public int GetSizeDelta()
        {
            int ret = _sizeDelta;
            _sizeDelta = 0;
            return ret;
        }

        private static void Debug(string s)
        {
            // Console.Write(s);
        }

        private static void DebugLine(string s)
        {
            Debug(s + "\n");
        }

        private void Debug(string mode, int x, int z, string i)
        {
            Debug($"REGION {mode} {_fileName}[{x},{z}] = {i}");
        }

        private void Debug(string mode, int x, int z, int count, string i)
        {
            Debug($"REGION {mode} {_fileName}[{x},{z}] {count}B = {i}");
        }

        private void DebugLine(string mode, int x, int z, string i)
        {
            Debug(mode, x, z, $"{i}\n");
        }

        public BinaryReader GetChunkDataBinaryReader(int x, int z)
        {
            if (OutOfBounds(x, z))
            {
                DebugLine("READ", x, z, "out of bounds");
                return null;
            }

            try
            {
                int offset = GetOffset(x, z);
                if (offset == 0)
                {
                    // DebugLine("READ", x, z, "miss");
                    return null;
                }

                int sectorNumber = offset >> 8;
                int numSectors = offset & 0xFF;
                if (sectorNumber + numSectors > _sectorFree.Count)
                {
                    DebugLine("READ", x, z, "invalid sector");
                    return null;
                }

                _fout.Seek(sectorNumber * SectorBytes, SeekOrigin.Begin);
                using (var bReader = new BinaryReader(_fout))
                {
                    int length = bReader.ReadInt32();

                    if (length > SectorBytes * numSectors)
                    {
                        DebugLine("READ", x, z, 
                            $"invalid length: {length} > 4096 * {numSectors}");
                        return null;
                    }

                    byte version = bReader.ReadByte();
                    byte[] data = new byte[length - 1];
                    bReader.Read(data, 0, length);
                    if (version == VersionGZip)
                    {
                        BinaryReader bR = new BinaryReader(
                            new GZipInputStream(
                                bReader.BaseStream));
                        // Debug("READ", x, z, " = found");
                        return bR;
                    }

                    if (version == VersionDeflate)
                    { 
                        BinaryReader bR = new BinaryReader(
                            new InflaterInputStream(
                                bReader.BaseStream)
                        );
                        // Debug("READ", x, z, " = found");
                        return bR;
                    }

                    DebugLine("READ", x, z, $"unknown version {version}");
                    return null;
                }
            }
            catch (IOException e)
            {
                DebugLine("READ", x, z, "exception");
                return null;
            }
        }

        public BinaryWriter GetChunkDataOutputStream(int x, int z)
        {
            if (OutOfBounds(x, z)) return null;

            return new BinaryWriter(new DeflaterOutputStream(
                new ChunkBuffer(x, z, this).BaseStream));
        }

        private class ChunkBuffer : BinaryWriter
        {
            private readonly int _x, _z;
            private readonly RegionFile _parent;

            public ChunkBuffer(int x, int z, RegionFile parent)
            {
                OutStream.SetLength(8096); // Initialized to 8KB
                _x = x;
                _z = z;
                _parent = parent;
            }

            public override void Close()
            {
                _parent.Write(_x, _z,
                    new BinaryReader(OutStream).ReadBytes(8096),
                    (int) OutStream.Length);
            }
        }

        protected void Write(int x, int z, byte[] data, int length)
        {
            try
            {
                int offset = GetOffset(x, z);
                int sectorNumber = offset >> 8;
                int sectorsAllocated = offset & 0xFF;
                int sectorsNeeded = (length + ChunkHeaderSize) / SectorBytes + 1;

                // maximum chunk size is 1MB
                if (sectorsNeeded >= 256)
                {
                    return;
                }

                if (sectorNumber != 0 && sectorsAllocated == sectorsNeeded)
                {
                    // we can simply overwrite the old sectors
                    Debug("SAVE", x, z, length, "rewrite");
                    Write(sectorNumber, data, length);
                }
                else
                {
                    // we need to allocate new sectors
                    // mark the sectors previously used for this chunk as free
                    for (int i = 0; i < sectorsAllocated; ++i)
                    {
                        _sectorFree[sectorNumber + 1] = true;
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
                                runLength =
                                    _sectorFree[i]
                                        ? runLength + 1
                                        : 0;
                            }
                            else if (_sectorFree[i])
                            {
                                runStart = i;
                                runLength = 1;
                            }

                            if (runLength >= sectorsNeeded)
                            {
                                break;
                            }
                        }
                    }

                    if (runLength >= sectorsNeeded)
                    {
                        // we found a free space large enough
                        Debug("SAVE", x, z, length, "reuse");
                        sectorNumber = runStart;
                        SetOffset(x, z, (sectorNumber << 8) | sectorsNeeded);

                        for (int i = 0; i < sectorsNeeded; ++i)
                        {
                            _sectorFree[sectorNumber + i] = false;
                        }

                        Write(sectorNumber, data, length);
                    }
                    else
                    {
                        /*
                         * no free space large enough found -- we need to grow
                         * the file
                         */
                        Debug("SAVE", x, z, length, "grow");
                        _fout.Seek(_fout.Length, SeekOrigin.Begin);
                        sectorNumber = _sectorFree.Count;

                        for (int i = 0; i < sectorsNeeded; ++i)
                        {
                            _bw.Write(_emptySector);
                            _sectorFree.Add(false);
                        }

                        _sizeDelta += SectorBytes * sectorsNeeded;

                        Write(sectorNumber, data, length);
                        SetOffset(x, z, (sectorNumber << 8) | sectorsNeeded);
                    }
                }

                SetTimestamp(x, z, (int) (DateTime.Now.Millisecond / 1000L));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// Write a chunk data to the region file at specified sector number
        /// </summary>
        private void Write(int sectorNumber, byte[] data, int length)
        {
            DebugLine(" " + sectorNumber);
            _fout.Seek(sectorNumber * SectorBytes, SeekOrigin.Begin);
            WriteInt(length + 1); // chunk length
            WriteByte(VersionDeflate); // chunk version number
            _fout.Write(data, 0, length);
        }

        /// <summary>
        /// Is this an invalid chunk coordinate?
        /// </summary>
        private static bool OutOfBounds(int x, int z)
        {
            return x < 0 || x > 32 || z < 0 || z >= 32;
        }

        private int GetOffset(int x, int z)
        {
            return _offsets[x + z * 32];
        }

        public bool HasChunk(int x, int z)
        {
            return GetOffset(x, z) != 0;
        }

        private void SetOffset(int x, int z, int offset)
        {
            _offsets[x + z * 32] = offset;
            _fout.Seek((x + z * 32) * 4, SeekOrigin.Begin);
            WriteInt(offset);
        }

        private void SetTimestamp(int x, int z, int value)
        {
            _chunkTimeStamps[x + z * 32] = value;
            _fout.Seek(SectorBytes + (x + z * 32) * 4, SeekOrigin.Begin);
            WriteInt(value);
        }

        public void Close()
        {
            _fout.Close();
        }

        private FileStream _fout;
        private BinaryWriter _bw;
        private void WriteInt(int i)
        {
            _fout = new FileStream(_fileName, FileMode.Append, FileAccess.Write);
            _bw = new BinaryWriter(_fout);
            _bw.Write(i);
            _bw.Close();
            _fout.Close();
        }

        private void WriteByte(byte b)
        {
            _fout = new FileStream(_fileName, FileMode.Append, FileAccess.Write);
            _bw = new BinaryWriter(_fout);
            _bw.Write(b);
            _bw.Close();
            _fout.Close();
        }

    }
}
