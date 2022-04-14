using MinecraftTypes;

namespace SmartBlocks.Entities;

public class Marker : Entity
{
    public override string Name => "Marker";

    public override VarInt Type => 49;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => false;

    public override BoundingBox BoundingBox => new(0, 0, 0);

    public override Identifier Identifier => new("marker");
}