namespace SmartBlocks.Entities.Living.Monsters;

public abstract class AbstractSkeleton : Monster
{
    public override string Name => "Abstract Skeleton";

    public override bool UseSpawnEntityOnly => true;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => false;
}