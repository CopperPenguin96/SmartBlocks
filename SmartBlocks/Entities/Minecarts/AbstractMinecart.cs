using MinecraftTypes;

namespace SmartBlocks.Entities.Minecarts;

public abstract class AbstractMinecart : Entity
{
    public override string Name => "Abstract Minecart";

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => false;

    public VarInt ShakingPower { get; set; } = 0;

    public VarInt ShakingDirection { get; set; } = 1;

    public float ShakingMultiplier { get; set; } = 0.0f;

    public VarInt CustomBlockIdDamange { get; set; } = 0;

    public VarInt CustomBlockYPos { get; set; } = 6;

    public bool ShowCustomBlock { get; set; } = false;
}