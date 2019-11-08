using System.Collections.Generic;
using GemBlocks.Blocks;
using GemBlocks.Worlds;

namespace GemBlocks.Levels.Generators
{
    public class FlatGenerator : IGenerator
    {
        public static void Start()
        {
            /*
             * Create the base layers of the generated world.
             * We set the bottom layer of the world to be bedrock
             * and the 20 layers above to be melon
             * blocks.
             */
            DefaultLayers layers = new DefaultLayers();
            layers.SetLayer(0, BlockRegistry.Bedrock);
            layers.SetLayers(1, 20, BlockRegistry.MelonBlock);

            /*
             * Create the internal Minecraft world generator
             * We use a flat generator. We do this to make sure that the
             * whole world will be paved
             * with melons and not just the part we generated.
             */
            IGenerator gen = new FlatGenerator(layers);

            /*
             * Create the level config
             * We set the mode to creative mode and name our world.
             * We also set the spawn point in the middle of our
             * structure
             */
            Level level = new Level("MelonWorld", gen) {GameMode = GameMode.Creative};
            level.SetSpawnPoint(50, 0, 50);
        }

        private readonly DefaultLayers _layers;
        public FlatGenerator(DefaultLayers layers)
        {
            _layers = layers;
        }


        public GeneratorName GeneratorName { get; } = (GeneratorName)3;

        public string GeneratorOptions
        {
            get
            {
                // Are there layers?
                if (_layers == null) return null;

                // Create generator options string
                int lastBlockId = 0;
                int count = 0;
                List<string> parts = new List<string>();
                for (int y = 0; y <= World.MaxHeight; y++)
                {
                    bool isLast = y == World.MaxHeight;

                    int blockId = 0;
                    if (!isLast)
                    {
                        Block material = _layers.GetLayer(y);
                        if (material != null)
                        {
                            blockId = material.Meta;
                        }
                    }

                    if (y == 0 && !isLast)
                    {
                        // First pass
                        lastBlockId = blockId;
                    }
                    else
                    {
                        // Further passes
                        if (blockId != lastBlockId || isLast)
                        {
                            // Different block, add to string
                            string part = "";
                            if (count != 1)
                            {
                                part += count + "*";
                            }

                            part += lastBlockId;

                            // Don't add the last part if it's air
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

                // create option string
                string layerOptions = string.Join(",", parts);
                string options = "3;" + layerOptions;
                return options;
            }
        }
    }
}
