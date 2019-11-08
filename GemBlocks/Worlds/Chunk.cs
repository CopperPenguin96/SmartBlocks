using System;
using System.Linq;
using fNbt;
using GemBlocks.Blocks;

namespace GemBlocks.Worlds
{
    /// <summary>
    /// Defines a chunk. It consists of 16x16 blocks in XZ-dimension and up to 16
    /// sections for the height
    /// </summary>
    public class Chunk: IBlockContainer
    {
        public const int SectionsPerChunk = 16;
        public const int BlocksPerChunkSide = 16;
        private readonly Section[] _sections = new Section[SectionsPerChunk];
        private readonly int[,] _heightMap = new int[BlocksPerChunkSide, BlocksPerChunkSide];
        public int XPos { get; }
        public int ZPos { get; }
        private readonly IBlockContainer _parent;

        public Chunk(IBlockContainer parent, int xPos, int zPos, DefaultLayers layers)
        {
            _parent = parent;
            XPos = xPos;
            ZPos = zPos;

            // Set default blocks
            if (layers == null) return;
            // Iterate layers
            for (int y = 0; y < World.MaxHeight; y++)
            {
                Block material = layers.GetLayer(y);
                if (material == null) continue;
                // Create Block
                CustomBlock block = new CustomBlock(material.Type, 0)
                {
                    Transparency = material.Transparency
                };

                // Iterate area
                for (int x = 0; x < BlocksPerChunkSide; x++)
                {
                    for (int z = 0; z < BlocksPerChunkSide; z++)
                    {
                        // set block
                        SetBlock(x, y, z, block);
                    }
                }
            }
        }

        public void SetBlock(int x, int y, int z, Block block)
        {
            // Get section
            Section section = GetSection(y, true);

            // Set block
            int blockY = y % Section.SectionHeight;
            section.SetBlock(x, blockY, z, block);
        }

        public byte GetSkyLight(int x, int y, int z)
        {
            // Get section
            Section section = GetSection(y, false);

            if (section == null) return World.DefaultSkyLight;
            int blockY = y % Section.SectionHeight;
            byte light = section.GetSkyLight(x, blockY, z);
            return light;

        }

        private void SetSkyLight(int x, int y, int z, byte light)
        {
            // Get section
            Section section = GetSection(y, false);

            if (section == null) return;
            int blockY = y % Section.SectionHeight;
            section.SetSkyLight(x, blockY, z, light);
        }

        public byte GetSkyLightFromParent(IBlockContainer child,
            int childX, int childY, int childZ)
        {
            int y = ((Section) child).Y & Section.SectionHeight + childY;
            if (y >= World.MaxHeight) return World.DefaultSkyLight;
            if (y < 0) return 0;

            // which chunk?
            return childX >= 0 &&
                    childX < BlocksPerChunkSide &&
                    childZ >= 0 &&
                    childZ < BlocksPerChunkSide
                ? GetSkyLight(childX, y, childZ)
                : _parent.GetSkyLightFromParent(this, childZ, y, childZ);
        }

        public void SpreadSkyLight(byte light)
        {
            foreach (Section section in _sections)
            {
                section?.SpreadSkyLight(light);
            }
        }

        public void AddSkyLight()
        {
            for (int x = 0; x < BlocksPerChunkSide; x++)
            {
                for (int z = 0; z < BlocksPerChunkSide; z++)
                {
                    int highestBlock = GetHighestBlock(x, z);
                    for (int y = World.MaxHeight - 1; y >= highestBlock; y--)
                    {
                        SetSkyLight(x, y, z, World.DefaultSkyLight);
                    }
                }
            }
        }

        public int GetHighestBlock(int x, int z)
        {
            return _heightMap[x, z];
        }

        private Section GetSection(int y, bool create)
        {
            int sectionY = y / Section.SectionHeight;
            Section section = _sections[sectionY];

            if (section != null || !create) return section;
            section = new Section(this, sectionY);
            _sections[sectionY] = section;

            return section;
        }

        public bool HasBlocks()
        {
            return _sections.Any(section => section != null & section.BlockCount > 0);
        }

        public void CalculateHeightMap()
        {
            for (int y = SectionsPerChunk - 1; y >= 0; y--)
            {
                Section section = _sections[y];
                if (section == null) continue;
                // Iterate x/z-columns
                for (int x = 0; x < BlocksPerChunkSide; x++)
                {
                    for (int z = 0; z < BlocksPerChunkSide; z++)
                    {
                        // Update height
                        if (_heightMap[x, z] != 0) continue;
                        int height = section.GetHighestBlock(x, z);
                        if (height != -1)
                        {
                            _heightMap[x, z] = y * Section.SectionHeight + height + 1;
                        }
                    }
                }
            }
        }

        public NbtTag GetTag()
        {
            NbtList factory = new NbtList("Sections");

            foreach (Section section in _sections)
            {
                if (section != null && section.BlockCount > 0)
                {
                    factory.Add(section.Tag());
                }
            }

            // Make level tags
            NbtCompound factory2 = new NbtCompound("Level")
            {
                factory,
                new NbtInt("xPos", XPos),
                new NbtInt("zPos", ZPos),
                new NbtLong("LastUpdate", DateTime.Now.Millisecond),
                new NbtByte("V", 1),
                new NbtByte("LightPopulated", 1),
                new NbtByte("TerrainPopulated", 1)
            };

            // Make height map
            int[] heightMapAry = new int[BlocksPerChunkSide * BlocksPerChunkSide];
            int i = 0;

            for (int z = 0; z < BlocksPerChunkSide; z++)
            {
                for (int x = 0; x < BlocksPerChunkSide; x++)
                {
                    heightMapAry[i] = _heightMap[x, z];
                    i++;
                }
            }

            factory2.Add(new NbtIntArray("HeightMap", heightMapAry));

            // Make chunk tag
            return new NbtCompound("") {factory2};
        }
    }
}
