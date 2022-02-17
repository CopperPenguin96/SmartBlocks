using MinecraftTypes;
using SmartBlocks.Worlds;
using SmartNbt.Tags;

namespace SmartBlocks.Generators
{
    public class NetherGenerator : IGenerator
    {
        public GenType Type => GenType.TheNether;

        public Dimension Dimension => Dimension.TheNether;

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
                NbtCompound biomeSource = new("biome_source")
                {
                    new NbtString("preset", new Identifier("nether").ToString()),
                    new NbtLong("seed", Seed),
                    new NbtString("type", new Identifier("multi_noise").ToString())
                };

                NbtCompound generator = new("generator")
                {
                    biomeSource,
                    new NbtLong("seed", Seed),
                    new NbtString("settings", new Identifier("nether").ToString()),
                    new NbtString("type", new Identifier("noise").ToString())
                };

                return generator;
            }
        }
    }
}
