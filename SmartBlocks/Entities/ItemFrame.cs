using MinecraftTypes;

namespace SmartBlocks.Entities;

public class ItemFrame : Entity
{
    public override string Name => "Item Frame";

    public override VarInt Type => 42;

    public override bool UseSpawnEntityOnly => true;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.75, 0.75, 0.75);

    public override Identifier Identifier => new("item_frame");

    public Slot Item { get; set; }

    public VarInt Rotation { get; set; } = 0;
}