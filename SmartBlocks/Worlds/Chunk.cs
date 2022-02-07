using MinecraftTypes;
using SmartBlocks.Blocks;
using SmartBlocks.Generators;
using SmartNbt.Tags;

namespace SmartBlocks.Worlds
{
    public class Chunk : ITagProvider, IBlockContainer
    {
        /// <summary>
        /// Sections per chunk side
        /// </summary>
        public const int SectionsPerChunk = 16;

        /// <summary>
        /// Blocks per chunk side
        /// </summary>
        public const int BlocksPerChunkSide = 16;

        public Section[] Sections = new Section[SectionsPerChunk];
        public int[][] HeightMap = new RectArray<int>(BlocksPerChunkSide, BlocksPerChunkSide).ToArray();
        public IBlockContainer Parent;

        public IGenerator Generator => Parent.Generator;
        /// <summary>
        /// Creates a new instance.
        /// </summary>
        /// <param name="parent">The parent block container</param>
        /// <param name="xpos">The X-coordinate within the region</param>
        /// <param name="zpos">The Z-coordinate within the region</param>
        /// <param name="layers">The default layers. Can be 'null'</param>
        public Chunk(IBlockContainer parent, int xpos, int zpos)
        {
            Parent = parent;
            X = xpos;
            Z = zpos;

            // Set default blocks
            if (parent == null) return;

            switch (Generator.Type)
            {
                case GenType.Flat:
                    FlatGenerator flat = (FlatGenerator) Generator;
                    LoadFlat(flat);
                    break;
            }
        }

        private void LoadFlat(FlatGenerator gen)
        {
            // Iterate layers
            for (int y = 0; y < World.MaxHeight; y++) // max height
            {
                DefaultLayers layers = gen.Layers;
                Block? material = layers.GetLayer(y);
                if (material == null) continue;
                // Iterate area
                for (int x = 0; x < BlocksPerChunkSide; x++)
                {
                    for (int z = 0; z < BlocksPerChunkSide; z++)
                    {
                        // Set Block
                        SetBlock(new Position(x, y, z), material);
                    }
                }
            }
        }

        public int X { get; }

        public int Z { get; }

        /// <summary>
        /// Sets a block at the given position
        /// </summary>
        public void SetBlock(Position pos, Block? block)
        {
            if (pos == null) throw new ArgumentNullException(nameof(pos));
            // Get section
            Section section = GetSection((int)pos.Y, true);

            // Set Block
            int blockY = (int)pos.Y % Section.SectionHeight;
            section.SetBlock(new Position(pos.X, blockY, pos.Z), block);
        }

        public byte GetSkyLight(Position pos)
        {
            if (pos == null) throw new ArgumentNullException(nameof(pos));

            // Get section
            Section section = GetSection((int)pos.Y, false);
            if (section != null)
            {
                int blockY = (int)pos.Y % Section.SectionHeight;
                byte light = section.GetSkyLight(new Position(pos.X, blockY, pos.Z));
                return light;
            }

            return World.DefaultSkyLight;
        }

        public void SetSkyLight(Position pos, byte light)
        {
            if (pos == null) throw new ArgumentNullException(nameof(pos));
            // Get Section
            Section section = GetSection((int)pos.Y, false);

            if (section != null)
            {
                int blockY = (int)pos.Y % Section.SectionHeight;
                section.SetSkyLight(new Position(pos.X, blockY, pos.Z), light);
            }
        }

        public byte GetSkyLightFromParent(IBlockContainer block, Position child)
        {
            if (child == null) throw new ArgumentNullException(nameof(child));
            if (block == null) throw new ArgumentNullException(nameof(block));

            // Get total y
            int y = ((Section)block).Y * Section.SectionHeight + (int)child.Y;
            if (y >= World.MaxHeight)
            {
                return World.DefaultSkyLight;
            }

            if (y < 0) return 0;

            // Which chunk?
            if (child.X is >= 0 and < BlocksPerChunkSide && child.Z is >= 0 and < BlocksPerChunkSide)
            {
                // Same chunk
                return GetSkyLight(new Position(child.X, y, child.Z));
            }
            else
            {
                return Parent.GetSkyLightFromParent(this, new Position(child.X, y, child.Z));
            }
        }

        public void SpreadSkyLight(byte light)
        {
            foreach (Section section in Sections)
            {
                section?.SpreadSkyLight(light);
            }
        }

        /// <summary>
        /// Adds the sky light. Starts from the top of each column and
        /// sets the sky light to full, up to the first non-transparent
        /// block.
        /// </summary>
        public void AddSkyLight()
        {
            for (int x = 0; x < BlocksPerChunkSide; x++)
            {
                for (int z = 0; z < BlocksPerChunkSide; z++)
                {
                    int highestBlock = GetHighestBlock(x, z);
                    for (int y = World.MaxHeight - 1; y >= highestBlock; y--)
                    {
                        SetSkyLight(new Position(x, y, z), World.DefaultSkyLight);
                    }
                }
            }
        }

        /// <summary>
        /// Returns the highest non transparent block.
        /// CalculateHeightMap() has to be invoked before
        /// calling this method to get actual results.
        /// </summary>
        /// <param name="x">The X-coordinate</param>
        /// <param name="z">The Z-coordinate</param>
        /// <returns>The y coordinate of the highest block</returns>
        public int GetHighestBlock(int x, int z)
        {
            return HeightMap[x][z];
        }

        private Section GetSection(int y, bool create)
        {
            // Get Section
            int sectionY = y / Section.SectionHeight;
            Section section = Sections[sectionY];
            // Create section
            if (section != null || !create) return section;
            section = new Section(this, sectionY);
            Sections[sectionY] = section;

            return section;
        }

        /// <summary>
        /// True if there is at least 1 block that is not air
        /// </summary>
        public bool HasBlocks => Sections.Any(section => section != null && section.BlockCount > 0);

        /// <summary>
        /// Calculates the height map.
        /// </summary>
        public void CalculateHeightMap()
        {
            // Iterate sections from top to bottom
            for (int y = SectionsPerChunk - 1; y >= 0; y--)
            {
                Section section = Sections[y];
                if (section == null) continue;
                // Iterate X/Z columns
                for (int x = 0; x < BlocksPerChunkSide; x++)
                {
                    for (int z = 0; z < BlocksPerChunkSide; z++)
                    {
                        // Update height
                        if (HeightMap[x][z] != 0) continue;
                        int height = section.GetHighestBlock(x, z);
                        if (height != -1)
                        {
                            HeightMap[x][z] = y * Section.SectionHeight + height + 1;
                        }
                    }
                }
            }
        }

        public NbtTag Tag
        {
            get
            {
                // Get section tags
                NbtList list = new("Sections");
                foreach (Section section in Sections)
                {
                    if (section is {BlockCount: > 0})
                    {
                        list.Add(section.Tag);
                    }
                }

                // Make level tags
                NbtCompound levelTag = new("Level")
                {
                    list,
                    new NbtInt("xPos", X),
                    new NbtInt("zPos", Z),
                    new NbtLong("LastUpdate", DateTime.Now.Ticks),
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
                        heightMapAry[i] = HeightMap[x][z];
                        i++;
                    }
                }

                levelTag.Add(new NbtIntArray("HeightMap", heightMapAry));

                // Make chunk tag and return it
                return new NbtCompound("")
                {
                    levelTag
                };
            }
        }

    }
}
