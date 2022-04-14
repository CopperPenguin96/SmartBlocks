namespace SmartBlocks.Entities.Living.Mobs;

public abstract class AbstractFish : WaterAnimal
{
    public override string Name => "Abstract Fish";

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => false;

    public bool FromBucket { get; set; } = false;
}