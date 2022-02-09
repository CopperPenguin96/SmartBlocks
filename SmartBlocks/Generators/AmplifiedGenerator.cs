using MinecraftTypes;
using SmartBlocks.Worlds;
using SmartNbt.Tags;

namespace SmartBlocks.Generators
{
    public class AmplifiedGenerator : IGenerator
    {
        public GenType Type => GenType.Amplified;

        public string Options { get; }

        private long _seed = -1;

        /// <summary>
        /// Gets or sets seed value. If seed is not set, then returns a random value.
        /// </summary>
        public long Seed
        {
            get
            {
                if (_seed == -1)
                {
                    _seed = new Random(new Random().Next()).NextInt64();
                }

                return _seed;
            }
            set => _seed = value;
        }

        public NbtTag Tag
        {
            get
            {
                // Biome Source
                NbtCompound biomeSource = new("biome_source")
                {
                    new NbtLong("seed", Seed),
                    new NbtBoolean("large_biomes", false),
                    new NbtString("type", new Identifier("vanilla_layered").ToString())
                };

                // Build Nbt
                return new NbtCompound("generator")
                {
                    new NbtString("settings", new Identifier("amplified").ToString()),
                    new NbtLong("seed", Seed),
                    new NbtString("type", new Identifier("noise").ToString()),
                    biomeSource
                };
            }
        }
    }
}