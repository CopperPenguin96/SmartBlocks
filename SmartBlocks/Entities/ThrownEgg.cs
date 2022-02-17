using MinecraftTypes;

namespace SmartBlocks.Entities
{
    public class ThrownEgg : Entity
    {
        public override string Name => "Thrown Egg";

        public override VarInt Type => 89;

        internal override bool UseSpawnEntityOnly => true;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.25, 0.25, 0.25);
        
        public override Identifier Identifier => new("egg");

        /// <summary>
        /// Empty, (which behaves as if it were an egg)
        /// </summary>
        public Slot Item { get; set; }
    }
}
