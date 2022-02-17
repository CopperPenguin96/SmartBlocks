using MinecraftTypes;

namespace SmartBlocks.Entities.Particles
{
    public class BlockParticle : Particle
    {
        public override VarInt Id => 4;

        public override Identifier Name => "block";

        public VarInt BlockState { get; set; }
    }
}
