using MinecraftTypes;

namespace SmartBlocks.Entities.Particles;

public class FallingDust : Particle
{
    public override VarInt Id => 25;

    public override Identifier Name => "falling_dust";

    /// <summary>
    /// The ID of the block state
    /// </summary>
    public VarInt BlockState { get; set; }
}