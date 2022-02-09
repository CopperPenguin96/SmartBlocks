using MinecraftTypes;
using SmartBlocks.Blocks;
using SmartBlocks.Generators;
using SmartNbt.Tags;

namespace SmartBlocks.Worlds
{
    /// <summary>
    /// Defines a section. It consists of 16 blocks in each dimension.
    /// </summary>
    public class Section : ITagProvider, IBlockContainer
    {
        public IGenerator Generator => _parent.Generator;

        /// <summary>
        /// The height in blocks of a section
        /// </summary>
        public const int SectionHeight = 16;

        /// <summary>
        /// The total number of blocks in a section
        /// </summary>
        public const int BlocksPerSection =
            Chunk.BlocksPerChunkSide * Chunk.BlocksPerChunkSide * SectionHeight;

        private readonly byte[] _blockIds = new byte[BlocksPerSection];
        private readonly byte[] _transparency = new byte[BlocksPerSection];
        private readonly NibbleArray _blockData = new NibbleArray(BlocksPerSection);
        private readonly NibbleArray _skyLight = new NibbleArray(BlocksPerSection);
        private readonly IBlockContainer _parent;

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

        /// <summary>
        /// The Y-position within the chunk
        /// </summary>
        public int Y { get; }

        /// <summary>
        /// Sets a block at the given position
        /// </summary>
        /// <param name="pos">The XYZ coords</param>
        /// <param name="block">The block</param>
        public void SetBlock(Position pos, Block? block)
        {
            // We ignore if it's air (air heads)
            if (block == new Block("air")) block = null!;

            // Count non-air blocks
            int index = GetBlockIndex(pos);
            if (_blockIds[index] == 0 && block == null) BlockCount++;
            else if (_blockIds[index] != 0 && block == null) BlockCount--;

            // Set block
            if (block != null)
            {
                _blockIds[index] = (byte) block.Id;
                _blockData.Set(index, (byte)block.Type);
            }
            else
            {
                _blockIds[index] = 0;
                _blockData.Set(index, (byte)0);
                _transparency[index] = World.DefaultTransparency;
            }
        }

        public byte GetTransparency(Position pos)
        {
            int index = GetBlockIndex(pos);
            byte light = _skyLight.Get(index);
            return light;
        }

        public byte GetSkyLight(Position pos)
        {
            int index = GetBlockIndex(pos);
            byte light = _skyLight.Get(index);
            return light;
        }

        public void SetSkyLight(Position pos, byte light)
        {
            int index = GetBlockIndex(pos);
            _skyLight.Set(index, light);
        }

        public byte GetSkyLightFromParent(IBlockContainer child, Position pos)
        {
            return IsInBounds(pos) ?
                GetSkyLight(pos)
                : _parent.GetSkyLightFromParent(this, pos);
        }

        public void SpreadSkyLight(byte light)
        {
            // Iterate blocks with 1 offset to all sides to get light
            // from adjacent sections
            for (int x = -1; x <= Chunk.BlocksPerChunkSide; x++)
            {
                for (int y = -1; y <= SectionHeight; y++)
                {
                    for (int z = -1; z <= Chunk.BlocksPerChunkSide; z++)
                    {
                        Position pos = new Position(x, y, z);
                        byte currentLight = GetSkyLightFromParent(null, pos);
                        if (currentLight == light)
                        {
                            SpreadSkyLightForBlock(pos, light);
                        }
                    }
                }
            }
        }

        private void SpreadSkyLightForBlock(Position pos, byte light)
        {
            IncreaseSkyLight(new Position(pos.X + 1, pos.Y, pos.Z), light);
            IncreaseSkyLight(new Position(pos.X - 1, pos.Y, pos.Z), light);
            IncreaseSkyLight(new Position(pos.X, pos.Y + 1, pos.Z), light);
            IncreaseSkyLight(new Position(pos.X, pos.Y - 1, pos.Z), light);
            IncreaseSkyLight(new Position(pos.X, pos.Y, pos.Z + 1), light);
            IncreaseSkyLight(new Position(pos.X, pos.Y, pos.Z - 1), light);
        }

        public void IncreaseSkyLight(Position pos, byte light)
        {
            // Check if block is within bounds
            if (!IsInBounds(pos))
            {
                return;
            }

            // Calculate the new light level
            byte transparency = GetTransparency(pos);
            if (transparency == 0)
            {
                return;
            }
            else if (transparency > 1)
            {
                light -= transparency;
            }

            light--;
            if (light < 1)
            {
                return;
            }

            // Update if current light is lower
            if (GetSkyLight(pos) < light)
            {
                SetSkyLight(pos, light);
            }
        }

        private static bool IsInBounds(Position pos)
        {
            int x = (int)pos.X;
            int y = (int)pos.Y;
            int z = (int)pos.Z;
            if (x < 0 || x > Chunk.BlocksPerChunkSide - 1)
            {
                return false;
            }

            if (y < 0 || y > SectionHeight - 1)
            {
                return false;
            }

            // ReSharper disable once ConvertIfStatementToReturnStatement
            if (z < 0 || z > Chunk.BlocksPerChunkSide - 1)
            {
                return false;
            }

            return true;
        }

        private static int GetBlockIndex(Position pos)
        {
            int x = (int)pos.X;
            int y = (int)pos.Y;
            int z = (int)pos.Z;
            int index = 0;
            index += y * Chunk.BlocksPerChunkSide * Chunk.BlocksPerChunkSide;
            index += z * Chunk.BlocksPerChunkSide;
            index += x;
            return index;
        }

        /// <summary>
        /// The number of blocks that are not air
        /// </summary>
        public int BlockCount { get; private set; } = 0;

        public int GetHighestBlock(int x, int z)
        {
            // Iterate column
            for (int y = SectionHeight - 1; y >= 0; y--)
            {
                int index = GetBlockIndex(new Position(x, y, z));
                if (_blockIds[index] != 0 && _transparency[index] != 1)
                {
                    return y;
                }
            }

            return -1;
        }

        public NbtTag Tag =>
            // Create tag
            new NbtCompound()
            {
                new NbtByteArray("Blocks", _blockIds),
                new NbtByteArray("Data", _blockData.Bytes),
                new NbtByteArray("BlockLight", new NibbleArray(BlocksPerSection).Bytes),
                new NbtByteArray("SkyLight", _skyLight.Bytes),
                new NbtByte("Y", (byte) Y)
            };
    }
}
