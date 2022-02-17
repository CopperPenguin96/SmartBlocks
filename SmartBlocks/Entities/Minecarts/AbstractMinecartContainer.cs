namespace SmartBlocks.Entities.Minecarts
{
    public abstract class AbstractMinecartContainer : AbstractMinecart
    {
        public override string Name => "Abstract Minecart Container";

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => false;
    }
}
