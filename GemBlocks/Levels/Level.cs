using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Extension_Methods;
using fNbt;

namespace GemBlocks.Levels
{
    public class Level
    {
        public string LevelName { get; }

        /// <summary>
        /// If cheats are allowed. The default value is 'false'
        /// </summary>
        public bool AllowCommands { get; } = false;

        /// <summary>
        /// Structures
        /// </summary>
        public bool MapFeatures { get; } = true;

        public GameMode GameMode { get; } = GameMode.Creative;

        private int _spawnX, _spawnY, _spawnZ;

        public void SetSpawnPoint(int x, int y, int z)
        {
            _spawnX = x;
            _spawnY = y;
            _spawnZ = z;
        }

        /// <summary>
        /// The random seed used for world generation.
        /// </summary>
        public long RandomSeed { get; private set; }

        public IGenerator Generator { get; }

        public Level(string levelName)
        {
            LevelName = levelName;
            MakeRandomSeed();
        }

        public Level(string levelName, IGenerator gen)
        {
            LevelName = levelName;
            Generator = gen;
            MakeRandomSeed();
        }

        private void MakeRandomSeed()
        {
            Random rnd = new Random();
            long x = (long)((rnd.NextDouble() * 2.0 - 1.0) * long.MaxValue);
            RandomSeed = x;
        }

        public NbtTag Tag
        {
            get
            {
                NbtCompound factory = new NbtCompound("Data")
                {
                    new NbtByte("allowCommands", AllowCommands.ToByte()),
                    new NbtInt("GameType", (int) GameMode),
                    new NbtString("generatorName", GetName(Generator.GeneratorName)),
                    new NbtLong("LastPlayed", DateTime.Now.Millisecond),
                    new NbtString("LevelName", LevelName),
                    new NbtByte("MapFeatures", MapFeatures.ToByte()),
                    new NbtLong("RandomSeed", RandomSeed),
                    new NbtInt("SpawnX", _spawnX),
                    new NbtInt("SpawnY", _spawnY),
                    new NbtInt("SpawnZ", _spawnZ),
                    new NbtInt("version", 19133)
                };

                string ops = Generator.GeneratorOptions;
                if (ops != null)
                {
                    factory.Add(new NbtString("generatorOptions", ops));
                }

                // Make root tag and return it
                return new NbtCompound("") { factory };
            }
        }

        private static string GetName(Enum en)
        {
            Type type = en.GetType();
            MemberInfo[] memInfo = type.GetMember(en.ToString());

            if (memInfo.Length <= 0) return en.ToString();
            object[] attrs = memInfo[0].GetCustomAttributes(typeof(NameAttribute),
                false);

            return attrs.Length > 0 ? ((NameAttribute)attrs[0]).Name : en.ToString();
        }

    }
    
}
