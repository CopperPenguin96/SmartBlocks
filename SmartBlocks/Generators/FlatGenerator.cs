using MinecraftTypes;
using SmartBlocks.Blocks;
using SmartBlocks.Utils;
using SmartBlocks.Worlds;
using SmartNbt;
using SmartNbt.Tags;

namespace SmartBlocks.Generators
{
    /// <inheritdoc />
    /// <summary>
    /// Generates a super-flat world
    /// </summary>
    public class FlatGenerator : IGenerator
    {
        /// <summary>
        /// The default layers of this flat world
        /// </summary>
        public readonly DefaultLayers Layers;

        public Biome Biome { get; set; } = new Identifier("plains");

        public bool Lakes { get; set; } = false;

        public int StrongholdDistance { get; set; } = new Random().Next();

        public int StrongholdCount { get; set; } = new Random().Next();

        public int StrongholdSpread { get; set; } = new Random().Next();

        public List<Structure> Structures { get; set; } = new();

        public bool GenerateStructures { get; set; } = false;

        /// <summary>
        /// Unused?
        /// </summary>
        public FlatGenerator(bool genStructs = false)
        {
            GenerateStructures = genStructs;
        }

        /// <summary>
        /// Loads this instance with the desired layers
        /// </summary>
        /// <param name="layers"></param>
        public FlatGenerator(DefaultLayers layers, bool genStructs = false)
            : this(genStructs)
        {
            Layers = layers;
        }

        /// <inheritdoc />
        /// <summary>
        /// Used by the world generator
        /// </summary>
        public static string Name => "flat";

        public GenType Type => GenType.Flat;

        /// <inheritdoc />
        /// <summary>
        /// Used by the world generator
        /// </summary>
        public string Options
        {
            get
            {
                // Are there layers?
                if (Layers == null) return null;

                // Create generator options string
                int lastBlockId = 0;
                int count = 0;
                List<string> parts = new List<string>();
                for (int y = 0; y < World.MaxHeight; y++) // world max height
                {
                    bool isLast = y == World.MaxHeight; // world max height

                    // Get block id
                    int blockId = 0;
                    if (!isLast)
                    {
                        Block? material = Layers.GetLayer(y);
                        if (material != null)
                        {
                            blockId = (int)material.Type;
                        }
                    }

                    if (y == 0 && !isLast)
                    {
                        lastBlockId = blockId;
                    }
                    else
                    {
                        // Further passes
                        if (blockId != lastBlockId || isLast)
                        {
                            // Dif. block, add to string
                            string part = "";
                            if (count != 1)
                            {
                                part += count + "*";
                            }

                            part += lastBlockId;

                            // Dont' add the last part if it's air
                            if (!isLast || lastBlockId != 0)
                            {
                                parts.Add(part);
                            }

                            lastBlockId = blockId;
                            count = 0;
                        }
                    }

                    count++;
                }

                // Create options string
                string layerOptions = parts.ToArray().Join(",");
                string options = "3;" + layerOptions;
                return options;
            }
        }

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
                // Get layers
                NbtList layersBlock = new("layers", NbtTagType.Compound);
                foreach (Block? layers in Layers.Layers)
                {
                    if (layers == null) continue;
                    NbtCompound layer = new()
                    {
                        new NbtInt("height", 1),
                        new NbtString("block", layers.TypeText)
                    };

                    layersBlock.Add(layer);
                }

                // Structures
                NbtCompound structs = new("structures")
                {
                    new NbtCompound("stronghold")
                    {
                        new NbtInt("distance", StrongholdDistance),
                        new NbtInt("count", StrongholdCount),
                        new NbtInt("spread", StrongholdSpread)
                    }
                };
                NbtCompound structures = new("structures");
                foreach (Structure str in this.Structures)
                {
                    structures.Add(new NbtCompound(str.Id.ToString())
                    {
                        new NbtInt("spacing", str.Settings.Spacing),
                        new NbtInt("separation", str.Settings.Separation),
                        new NbtInt("salt", str.Settings.Salt)
                    });
                }
                structs.Add(structures);

                // Build Nbt
                return new("generator")
                {
                    new NbtString("type", new Identifier("flat").ToString()),
                    new NbtCompound("settings")
                    {
                        layersBlock, // layers
                        new NbtString("biome", Biome.Id.ToString()),
                        new NbtBoolean("lakes", Lakes),
                        new NbtBoolean("features", GenerateStructures),
                        structs
                    }
                };
            }
        }
    }
}
