namespace SmartBlocks.Entities.Living.Monsters
{
    public abstract class AbstractIllager : Raider
    {
        public override string Name => "Abstract Illager";

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => false;
    }
}
