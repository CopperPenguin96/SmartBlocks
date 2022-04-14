using MinecraftTypes;

namespace SmartBlocks.Entities;

public class WitherSkull : Entity
{
    public override string Name => "Wither Skull";

    public override bool UseSpawnEntityOnly => true;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.3125, 0.3125, 0.3125);

    public override Identifier Identifier => new("wither_skull");

    public bool IsInvulnerable { get; set; } = false;
}