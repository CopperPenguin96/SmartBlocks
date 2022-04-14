using MinecraftTypes;
using SmartBlocks.Entities.Living.Mobs;

namespace SmartBlocks.Entities.Living.Ageable;

public class Mule : ChestedHorse
{
    public override string Name => "Mule";

    public override VarInt Type => 57;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(1.39648, 1.6, 1.39648);

    public override Identifier Identifier => new("mule");
    
}