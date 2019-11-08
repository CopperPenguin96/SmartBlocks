using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using fNbt;

namespace GemBlocks.Worlds
{
    public class Section: IBlockContainer
    {
        /// <summary>
        /// The height in blocks of a section
        /// </summary>
        public const int SectionHeight = 16;

        /// <summary>
        /// The total number of blocks in a section
        /// </summary>
        public const int BlocksPerSection =
            Chunk.BlocksPerChunkSide * Chunk.BlocksPerChunkSide * SectionHeight;

        private byte[] _blockIds = new byte[BlocksPerSection];
        private byte[] _transparency = new byte[BlocksPerSection];
        private NibbleArray _blockData = new NibbleArray(BlocksPerSection);
        private NibbleArray _skyLight = new NibbleArray(BlocksPerSection);
        public int BlockCount { get; private set; } = 0;
        public int Y { get; }
        private IBlockContainer _parent;

        public Section(IBlockContainer parent, int y)
        {
            _parent = parent;
            Y = y;

            // Set default transparency
            for (int i = 0; i < _transparency.Length; i++)
            {
                _transparency[i] = World.DefaultTransparency;
            }
        }

        public void SetBlock(int x, int y, int z, Block block)
        {
            // We shall ignore it if air
            if (block.Type == 0)
            {
                block = null;
            }

            // Count non-air blocks
            int index = GetBlockIndex(x, y, z);

            if (_blockIds[index] == 0 && block != null)
            {
                BlockCount++;
            }
            else if (_blockIds[index] != 0 && block == null)
            {
                BlockCount--;
            }

            // Set block
            if (block != null)
            {
                _blockIds[index] = (byte) block.Type;
                _blockData.Set(index, (byte) block.Meta);
                // TODO - implement transparency
            }
            else
            {
                _blockIds[index] = 0;
                _blockData.Set(index, 0);
                _transparency[index] = Worlds.DefaultTransparency;
            }
        }

        private byte GetTransparency(int x, int y, int z)
        {
            int index = GetBlockIndex(x, y, z);
            return _transparency[index];
        }

        public byte GetSkyLight(int x, int y, int z)
        {
            int index = GetBlockIndex(x, y, z);
            byte light = _skyLight.Get(index);
            return light;
        }

        public void SetSkyLight(int x, int y, int z, byte light)
        {
            int index = GetBlockIndex(x, y, z);
            _skyLight.Set(index, light);
        }

        public byte GetSkyLightFromParent(IBlockContainer child,
            int x, int y, int z)
        {
            return IsInBounds(x, y, z) ? GetSkyLight(x, y, z) : _parent.GetSkyLightFromParent(this, x, y, z);
        }

        public void SpreadSkyLight(byte light)
        {
            // Iterate blocks with 1 offset to all sides to get light from adjancant sections
            for (int x = -1; x <= Chunk.BlocksPerChunkSide; x++)
            {
                for (int y = -1; y <= SectionHeight; y++)
                {
                    for (int z = -1; z <= Chunk.BlocksPerChunkSide; z++)
                    {
                        byte currentLight = GetSkyLightFromParent(null, x, y, z);
                        if (currentLight == light)
                        {
                            SpreadSkyLightForBlock(x, y, z, light);
                        }
                    }
                }
            }
        }

        private void SpreadSkyLightForBlock(int x, int y, int z, byte light)
        {
            IncreaseSkyLight(x + 1, y, z, light);
            IncreaseSkyLight(x - 1, y, z, light);
            IncreaseSkyLight(x, y + 1, z, light);
            IncreaseSkyLight(x, y - 1, z, light);
            IncreaseSkyLight(x, y, z + 1, light);
            IncreaseSkyLight(x, y, z - 1, light);
        }

        private void IncreaseSkyLight(int x, int y, int z, byte light)
        {
            // Check if block is within bounds
            if (!IsInBounds(x, y, z)) return;

            // Calculate the new light level
            byte transparency = GetTransparency(x, y, z);
            if (transparency == 0) return;
            if (transparency > 1) light -= transparency;

            light--;
            if (light < 1) return;

            // Update if current light is lower

            if (GetSkyLight(x, y, z) < light)
            {
                SetSkyLight(x, y, z, light);
            }
        }

        private bool IsInBounds(int x, int y, int z)
        {
            if (x < 0 || x > Chunk.BlocksPerChunkSide - 1) return false;
            if (y < 0 || y > SectionHeight - 1) return false;
            return z >= 0 && z <= Chunk.BlocksPerChunkSide - 1;
        }

        private int GetBlockIndex(int x, int y, int z)
        {
            int index = 0;
            index += y * Chunk.BlocksPerChunkSide * Chunk.BlocksPerChunkSide;
            index += z * Chunk.BlocksPerChunkSide;
            index += x;
            return index;
        }

        public int GetHighestBlock(int x, int z)
        {
            // Iterate column
            for (int y = SectionHeight - 1; y >= 0; y--)
            {
                int index = GetBlockIndex(x, y, z);
                if (_blockIds[index] != 0 && _transparency[index] != 1)
                {
                    return y;
                }
            }

            return -1;
        }

        public NbtTag Tag()
        {
            NbtCompound factory = new NbtCompound("")
            {
                new NbtByteArray("Blocks", _blockIds),
                new NbtByteArray("Data", _blockData.RawData),
                new NbtByteArray("BlockLight", new NibbleArray(BlocksPerSection).RawData),
                new NbtByteArray("SkyLight", _skyLight.RawData),
                new NbtByte("Y", (byte) Y)
            };

            return factory;
        }
    }
}
