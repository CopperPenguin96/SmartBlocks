using MinecraftTypes;

namespace SmartBlocks.Entities;

public class PrimedExplosive : Entity
{
    public override string Name => "Primed TNT";

    public override VarInt Type => 69; // nice

    public override bool UseSpawnEntityOnly => true;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.98, 0.98, 0.98);

    public override Identifier Identifier => new("tnt");

    public VarInt FuseTime { get; set; } = 80;
}