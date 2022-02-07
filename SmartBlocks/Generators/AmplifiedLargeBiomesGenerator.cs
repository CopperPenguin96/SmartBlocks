using MinecraftTypes;
using SmartNbt.Tags;

namespace SmartBlocks.Generators
{
    public class AmplifiedLargeBiomesGenerator : IGenerator
    {
        public GenType Type => GenType.AmplifiedLargeBiomes;

        public string Options { get; }

        public bool BonusChest { get; set; } = false;

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

        public NbtCompound Nbt
        {
            get
            {
                // Biome Source
                NbtCompound biomeSource = new("biome_source")
                {
                    new NbtLong("seed", Seed),
                    new NbtBoolean("large_biomes", true),
                    new NbtString("type", new Identifier("vanilla_layered").ToString())
                };

                // Build Nbt
                return new("generator")
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