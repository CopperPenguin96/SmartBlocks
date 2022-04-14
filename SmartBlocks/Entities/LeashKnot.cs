using MinecraftTypes;

namespace SmartBlocks.Entities;

public class LeashKnot : Entity
{
    public override string Name => "Leash Knot";

    public override VarInt Type => 44;

    public override bool UseSpawnEntityOnly => true;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.375, 0.5, 0.375);

    public override Identifier Identifier => new("leash_knot");
}