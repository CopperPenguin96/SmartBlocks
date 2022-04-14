namespace SmartBlocks.Entities.Living.Monsters;

public abstract class AbstractIllager : Raider
{
    public override string Name => "Abstract Illager";

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => false;
}