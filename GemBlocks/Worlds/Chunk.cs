using System;
using System.Linq;
using GemBlocks.Blocks;
using GemBlocks.Tags;
using GemBlocks.Utils;
using org.jnbt;
using static GemBlocks.Utils.JavaSystem;
/*
* The MIT License (MIT)
* 
* Copyright (c) 2014-2015 Merten Peetz
* 
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
* 
* The above copyright notice and this permission notice shall be included in all
* copies or substantial portions of the Software.
* 
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
* SOFTWARE.
*/
/*
 * Modified License
* The MIT License (MIT)
* 
* Copyright (c) 2019 by apotter96
* 
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
* 
* The above copyright notice and this permission notice shall be included in all
* copies or substantial portions of the Software.
* 
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
* SOFTWARE.
*/
namespace GemBlocks.Worlds
{
    /// <summary>
    /// Defines a chunk.
    /// It consists of 16x16 blocks in XZ-dimension and up to
    /// 16 sections for the height.
    /// </summary>
    public class Chunk: ITagProvider, IBlockContainer
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
        private readonly int _xPos, _zPos;
        public IBlockContainer Parent;

        /// <summary>
        /// Creates a new instance.
        /// </summary>
        /// <param name="parent">The parent block container</param>
        /// <param name="xpos">The X-coordinate within the region</param>
        /// <param name="zpos">The Z-coordinate within the region</param>
        /// <param name="layers">The default layers. Can be 'null'</param>
        public Chunk(IBlockContainer parent, int xpos, int zpos, DefaultLayers layers)
        {
            Parent = parent;
            _xPos = xpos;
            _zPos = zpos;

            // Set default blocks
            if (layers == null) return;
            // Iterate layers
            for (int y = 0; y < World.MaxHeight; y++)
            {
                Block material = layers.GetLayer(y);
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

        public int X => _xPos;
        public int Z => _zPos;

        /// <summary>
        /// Sets a block at the given position
        /// </summary>
        public void SetBlock(Position pos, Block block)
        {
            if (pos == null) throw new ArgumentNullException(nameof(pos));
            // Get section
            Section section = GetSection(pos.Y, true);

            // Set Block
            int blockY = pos.Y % Section.SectionHeight;
            section.SetBlock(new Position(pos.X, blockY, pos.Z), block);
        }
        
        public byte GetSkyLight(Position pos)
        {
            if (pos == null) throw new ArgumentNullException(nameof(pos));
            
            // Get section
            Section section = GetSection(pos.Y, false);
            if (section != null)
            {
                int blockY = pos.Y % Section.SectionHeight;
                byte light = section.GetSkyLight(new Position(pos.X, blockY, pos.Z));
                return light;
            }

            return World.DefaultSkyLight;
        }

        public void SetSkyLight(Position pos, byte light)
        {
            if (pos == null) throw new ArgumentNullException(nameof(pos));
            // Get Section
            Section section = GetSection(pos.Y, false);

            if (section != null)
            {
                int blockY = pos.Y % Section.SectionHeight;
                section.SetSkyLight(new Position(pos.X, blockY, pos.Z), light);
            }
        }

        public byte GetSkyLightFromParent(IBlockContainer block, Position child)
        {
            if (child == null) throw new ArgumentNullException(nameof(child));
            if (block == null) throw new ArgumentNullException(nameof(block));

            // Get total y
            int y = ((Section) block).Y * Section.SectionHeight + child.Y;
            if (y >= World.MaxHeight)
            {
                return World.DefaultSkyLight;
            }

            if (y < 0) return 0;

            // Which chunk?
            if (child.X >= 0 && child.X < BlocksPerChunkSide &&
                child.Z >= 0 && child.Z < BlocksPerChunkSide)
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
                if (section != null) continue;
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

        public Tag Tag
        {
            get
            {
                // Get section tags
                ListTagFactory factory = new ListTagFactory("Sections", typeof(CompoundTag));
                foreach (Section section in Sections)
                {
                    if (section != null && section.BlockCount > 0)
                    {
                        factory.Add(section.Tag);
                    }
                }

                // Make level tags
                CompoundTagFactory factory2 = new CompoundTagFactory("Level");
                factory2.Set(factory.Tag);
                factory2.Set(new IntTag("xPos", X));
                factory2.Set(new IntTag("zPos", Z));
                factory2.Set(new LongTag("LastUpdate", CurrentTimeMillis()));
                factory2.Set(new ByteTag("V", (byte) 1));
                factory2.Set(new ByteTag("LightPopulated", (byte) 1));
                factory2.Set(new ByteTag("TerrainPopulated", (byte) 1));

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

                factory2.Set(new IntArrayTag("HeightMap", heightMapAry));

                // Make chunk tag
                CompoundTagFactory factory3 = new CompoundTagFactory("");
                factory3.Set(factory2.Tag);
                return factory3.Tag;
            }
        }
    }
}
