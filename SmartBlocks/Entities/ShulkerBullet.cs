using MinecraftTypes;

namespace SmartBlocks.Entities;

public class ShulkerBullet : Entity
{
    public override string Name => "Shulker Bullet";

    public override VarInt Type => 76;

    public override bool UseSpawnEntityOnly => true;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.3125, 0.3125, 0.3125);

    public override Identifier Identifier => new("shulker_bullet");
}