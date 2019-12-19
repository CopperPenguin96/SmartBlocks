using System;
using GemBlocks.Blocks.States;
using GemBlocks.Levels;
using GemBlocks.Levels.Generators;
using GemBlocks.Worlds;

namespace WorldGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*
                 * Determine the type of generator
                 * either by SimpleGenerator(WorldKinds)
                 * or by FlatGenerator(Layers)
                 */
                IGenerator gen = new SimpleGenerator(WorldKinds.Default);
                
                /*
                 * Name the world,
                 * assign the generator to the level,
                 * set the gamemode,
                 * set the spawn point
                 */
                Level level = new Level("SimpleWorld", gen)
                {
                    GameMode = GameMode.Creative, SpawnPoint = new Position(0, 50, 0)
                };

                // Load the level into a world
                World world = new World(level);
                
                // If I have to explain this one we have issues.
                world.Save();
            }
            finally
            {
                Console.WriteLine("Finished!");
            }
        }
    }
}
