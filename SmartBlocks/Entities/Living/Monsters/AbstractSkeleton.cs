namespace SmartBlocks.Entities.Living.Monsters
{
    public abstract class AbstractSkeleton : Monster
    {
        public override string Name => "Abstract Skeleton";

        internal override bool UseSpawnEntityOnly => true;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => false;
    }
}
