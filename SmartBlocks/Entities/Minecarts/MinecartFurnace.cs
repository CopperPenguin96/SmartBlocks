using MinecraftTypes;

namespace SmartBlocks.Entities.Minecarts;

public class MinecartFurnace : AbstractMinecart
{
    public override string Name => "Minecart Furnace";

    public override VarInt Type => 53;

    public override bool UseSpawnEntityOnly => true;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.98, 0.7, 0.98);

    public override Identifier Identifier => new("furnace_minecart");

    public bool HasFuel { get; set; } = false;
}