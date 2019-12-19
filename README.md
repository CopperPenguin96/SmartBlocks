**A C# library for easy generation of Minecraft worlds**

GemBlocks aims to provide a simple library for custom map generation. In order to use this library it is not necessary to deal with things like regions, chunks and block data. However it aims to implement all map features that Minecraft offers.

This library was forked from MorbZ/J2Blocks and converted to C# for use of .NET Minecraft implementations (Clients, World Editors, Servers, etc.)

Any assistance is welcomed! Please do a pull request if you see something that needs changed.
Also changed was the naming conventions. Java conventions don't look right in C#! :D
[→ GemBlocks Documentation] COMING SOON!

Example (TO BE UPDATED WITH REDONE C# CODE)
------
In this example, we generate a simple default world.

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

The world has been saved to the /world/ directory in our execution directory. We can move it to the Minecraft /saves/ directory and enjoy all the melons.

![The generated melon world](https://raw.githubusercontent.com/MorbZ/J2Blocks/master/doc/example.jpg)

Known Issues
------
(https://github.com/MorbZ/J2Blocks/blob/master/src/net/morbz/minecraft/blocks/Material.java) the blocks that have a check mark  
**Feel free to help and fix the issues by submitting a pull request.**
