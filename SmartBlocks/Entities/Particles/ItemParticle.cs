using MinecraftTypes;

namespace SmartBlocks.Entities.Particles;

public class ItemParticle : Particle
{
    public override VarInt Id => 36;

    public override Identifier Name => "item";

    /// <summary>
    /// The item that will be used
    /// </summary>
    public Slot Item { get; set; }
}