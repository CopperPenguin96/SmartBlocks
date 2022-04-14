using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Mobs;

public class PufferFish : AbstractFish
{
    public override string Name => "Pufferfish";

    public override VarInt Type => 70;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.7, 0.7, 0.7);

    public override Identifier Identifier => new("pufferfish");

    /// <summary>
    /// Varies from 0 to 2
    /// </summary>
    public VarInt PuffState { get; set; } = 0;
    
}