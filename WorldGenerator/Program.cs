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
                 * Simple
                 */
                IGenerator gen = new SimpleGenerator(WorldKinds.Default);
                Level level = new Level("SimpleWorld", gen)
                {
                    GameMode = GameMode.Creative, SpawnPoint = new Position(0, 50, 0)
                };

                World world = new World(level);
                world.Save();
            }
            finally
            {
                Console.WriteLine("Finished!");
            }
        }
    }
}
