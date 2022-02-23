using MinecraftTypes;

namespace SmartBlocks.Entities
{
    public class ThrownEnderPearl : Entity
    {
        public override string Name => "Thrown Ender Pearl";

        public override VarInt Type => 90;

        public override bool UseSpawnEntityOnly => true;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.25, 0.25, 0.25);

        public override Identifier Identifier => new("ender_pearl");

        public Slot Item { get; set; }
    }
}
