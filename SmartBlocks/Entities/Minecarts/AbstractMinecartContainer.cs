namespace SmartBlocks.Entities.Minecarts;

public abstract class AbstractMinecartContainer : AbstractMinecart
{
    public override string Name => "Abstract Minecart Container";

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => false;
}