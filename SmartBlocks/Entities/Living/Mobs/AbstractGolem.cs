namespace SmartBlocks.Entities.Living.Mobs
{
    public abstract class AbstractGolem : PathFinderMob
    {
        public override string Name => "Abstract Golem";

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => false;

        public override BoundingBox BoundingBox => new(0.98, 0.98, 0.98);
    }
}
