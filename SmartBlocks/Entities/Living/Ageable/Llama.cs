using MinecraftTypes;
using SmartBlocks.Entities.Living.Mobs;

namespace SmartBlocks.Entities.Living.Ageable;

public class Llama : ChestedHorse
{
    public override string Name => "Llama";

    public override VarInt Type => 46;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.9, 1.87, 0.9);

    public override Identifier Identifier => new("llama");

    /// <summary>
    /// Number of columns of 3 slots in the llama's inventory
    /// once a chest is equipped
    /// </summary>
    public VarInt Strength { get; set; } = 0;

    /// <summary>
    /// A dye color, or -1 if no carpet equipped
    /// </summary>
    public VarInt CarpetColor { get; set; } = -1;

    public LlamaVariant Variant { get; set; } = 0;
    
}