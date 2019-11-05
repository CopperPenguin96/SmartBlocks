using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using fNbt;

namespace GemBlocks.Level
{
    class DefaultGenerator : IGenerator
    {
        public GeneratorName GeneratorName => GeneratorName.Default;
        public string GeneratorOptions { get; }
        public string Name { get; }
        public bool AllowCommands { get; set; }
        public bool EnableStructures { get; set; }
        public GameMode GameMode { get; set; }
        public Position Spawn { get; set; }
        public long Seed { get; set; }

        public DefaultGenerator(string name)
        {
            Name = name;
            Seed = GetRandomSeed();
        }

        public NbtTag Tag()
        {
            NbtCompound compound = new NbtCompound("Data")
            {
                new NbtByte("allowCommands", AllowCommands.ToByte()),
                new NbtInt("GameType", (int) GameMode),
                new NbtString("generatorName", GetName(GeneratorName)),
                new NbtLong("LastPlayed", DateTime.Now.Millisecond),
                new NbtString("LevelName", Name),
                new NbtByte("MapFeatures", EnableStructures.ToByte()),
                new NbtLong("RandomSeed", Seed),
                new NbtInt("SpawnX", Spawn.X),
                new NbtInt("SpawnY", Spawn.Y),
                new NbtInt("SpawnZ", Spawn.Z),
                new NbtInt("version", 19133)
            };
            // TODO - consider flatgrass and options
            
            return new NbtCompound("") { compound };
        }

        static string GetName(Enum en)
        {
            Type type = en.GetType();
            MemberInfo[] memInfo = type.GetMember(en.ToString());

            if (memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(NameAttribute),
                    false);

                if (attrs.Length > 0)
                    return ((NameAttribute) attrs[0]).Name;
            }

            return en.ToString();
        }

        /// <summary>
        /// Generates a random seed
        /// </summary>
        /// <returns></returns>
        public long GetRandomSeed()
        {
            Random rnd = new Random();
            long x = (long) ((rnd.NextDouble() * 2.0 - 1.0) * long.MaxValue);
            return x;
        }
    }
}

