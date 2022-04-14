using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Mobs;

public class GlowSquid : Squid
{
    public override string Name => "Glow Squid";

    public override VarInt Type => 33;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.8, 0.8, 0.8);

    public override Identifier Identifier => new("glow_squid");
}