namespace SmartBlocks.Entities.Living.Mobs;

public abstract class AbstractGolem : PathFinderMob
{
    public override string Name => "Abstract Golem";

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => false;

    public override BoundingBox BoundingBox => new(0.98, 0.98, 0.98);
}