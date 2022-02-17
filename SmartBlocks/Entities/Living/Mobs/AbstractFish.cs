namespace SmartBlocks.Entities.Living.Mobs
{
    public abstract class AbstractFish : WaterAnimal
    {
        public override string Name => "Abstract Fish";

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => false;

        public bool FromBucket { get; set; } = false;
    }
}
