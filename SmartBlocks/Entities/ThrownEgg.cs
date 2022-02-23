using MinecraftTypes;

namespace SmartBlocks.Entities
{
    public class ThrownEgg : Entity
    {
        public override string Name => "Thrown Egg";

        public override VarInt Type => 89;

        public override bool UseSpawnEntityOnly => true;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.25, 0.25, 0.25);
        
        public override Identifier Identifier => new("egg");

        /// <summary>
        /// Empty, (which behaves as if it were an egg)
        /// </summary>
        public Slot Item { get; set; }
    }
}
