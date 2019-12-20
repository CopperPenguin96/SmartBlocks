using GemBlocks.Levels.Generators;
using GemBlocks.Tags;
using GemBlocks.Worlds;
using org.jnbt;
using static GemBlocks.Utils.JavaSystem;
using Math = java.lang.Math;
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
namespace GemBlocks.Levels
{
    /// <summary>
    /// The level defines the settings for the world.
    /// i.e. Game Mode, spawn point, etc.
    /// </summary>
    public class Level: ITagProvider
    {
        /// <summary>
        /// The name of the level
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Cheats enabled
        /// </summary>
        public bool AllowCommands { get; set; }

        /// <summary>
        /// Structures enabled
        /// </summary>
        public bool MapFeatures { get; set; }

        /// <summary>
        /// The gamemode of the world
        /// </summary>
        public GameMode GameMode { get; set; }

        /// <summary>
        /// Where new players spawn
        /// </summary>
        public Position SpawnPoint { get; set; }

        /// <summary>
        /// The seed of my fruitfulness
        /// </summary>
        public long RandomSeed { get; set; }

        /// <summary>
        /// The world generator, FlatGenerator is the default if none specified
        /// </summary>
        private readonly IGenerator _generator = new FlatGenerator();

        /// <summary>
        /// Initializes this instance, with Flat World
        /// </summary>
        /// <param name="levelName"></param>
        public Level(string levelName)
        {
            Name = levelName;
            MakeRandomSeed();
        }

        /// <summary>
        /// Initializes this instance
        /// </summary>
        /// <param name="levelName"></param>
        /// <param name="generator"></param>
        public Level(string levelName, IGenerator generator)
        {
            Name = levelName;
            _generator = generator;
        }

        /// <summary>
        /// Generates a random seed, positive numbers only
        /// </summary>
        private void MakeRandomSeed()
        {
            // TODO: add support for negative random values
            RandomSeed = (long) (Math.random() * long.MaxValue);
        }

        /// <summary>
        /// Gets the NBT Tag
        /// </summary>
        public Tag Tag
        {
            get
            {
                CompoundTagFactory factory = new CompoundTagFactory("Data");
                factory.Set(new ByteTag("allowCommands", AllowCommands ? (byte) 1 : (byte) 0));
                factory.Set(new IntTag("GameType", (int) GameMode));
                factory.Set(new StringTag("generatorName", _generator.Name));
                factory.Set(new LongTag("LastPlayed", CurrentTimeMillis()));
                factory.Set(new StringTag("LevelName", Name));
                factory.Set(new ByteTag("MapFeatures", MapFeatures ? (byte) 1 : (byte) 0));
                factory.Set(new LongTag("RandomSeed", RandomSeed));
                factory.Set(new IntTag("SpawnX", (int) SpawnPoint.X));
                factory.Set(new IntTag("SpawnY", (int) SpawnPoint.Y));
                factory.Set(new IntTag("SpawnZ", (int) SpawnPoint.Z));
                factory.Set(new IntTag("version", 19133));
                
                // Generator options
                string options = _generator.Options;
                if (options != null)
                {
                    factory.Set(new StringTag("generatorOptions", options));
                }

                // Make root tag
                CompoundTagFactory factory2 = new CompoundTagFactory("");
                factory2.Set(factory.Tag);
                return factory2.Tag;
            }
        }
    }
}
