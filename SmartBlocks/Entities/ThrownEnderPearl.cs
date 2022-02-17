using MinecraftTypes;

namespace SmartBlocks.Entities
{
    public class ThrownEnderPearl : Entity
    {
        public override string Name => "Thrown Ender Pearl";

        public override VarInt Type => 90;

        internal override bool UseSpawnEntityOnly => true;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.25, 0.25, 0.25);

        public override Identifier Identifier => new("ender_pearl");

        public Slot Item { get; set; }
    }
}
