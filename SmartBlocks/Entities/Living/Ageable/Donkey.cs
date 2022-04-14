using MinecraftTypes;
using SmartBlocks.Entities.Living.Mobs;

namespace SmartBlocks.Entities.Living.Ageable;

/// <summary>
/// Genesis 49:14 (KJV). Read it. You'll understand.
/// </summary>
public class Donkey : ChestedHorse
{
    public override string Name => "Donkey";

    public override VarInt Type => 15;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(1.5, 1.39648, 1.5);

    public override Identifier Identifier => "donkey";
    
}