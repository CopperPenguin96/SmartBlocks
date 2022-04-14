using java.util.jar;
using MinecraftTypes;
using SmartBlocks.Entities.Living.Mobs;

namespace SmartBlocks.Entities.Living.Monsters;

public class Stray : AbstractSkeleton
{
    public override string Name => "Stray";

    public override VarInt Type => 87;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.6, 1.99, 0.6);

    public override Identifier Identifier => new("stray");
    
}