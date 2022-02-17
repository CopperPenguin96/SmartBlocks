using MinecraftTypes;

namespace SmartBlocks.Entities.Particles
{
    public class Vibration : Particle
    {
        public override VarInt Id => 37;

        public override Identifier Name => "vibration";

        /// <summary>
        /// Starting coordinates
        /// </summary>
        public PosDouble Origin { get; set; }

        /// <summary>
        /// Ending coordinates
        /// </summary>
        public PosDouble Destination { get; set; }

        public int Ticks { get; set; }
    }
}
