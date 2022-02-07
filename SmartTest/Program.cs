// See https://aka.ms/new-console-template for more information

using MinecraftTypes;
using SmartBlocks;
using SmartBlocks.Blocks;
using SmartBlocks.Generators;
using SmartBlocks.Worlds;

Console.WriteLine("Hello, World!");
try
{
    World world = new("test/");
    
}
catch (Exception e)
{
    Console.WriteLine(e);
}
finally
{
    Console.WriteLine("DONE!");
}
Console.ReadLine();