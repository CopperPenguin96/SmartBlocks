using MinecraftTypes;

namespace SmartBlocks.Entities
{
    public class EyeOfEnder : Entity
    {
        public override string Name => "Eye of Ender";

        public override VarInt Type => 26;

        internal override bool UseSpawnEntityOnly => true;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.25, 0.25, 0.25);

        public override Identifier Identifier => new("eye_of_ender");

        public Slot Item { get; set; }
    }
}
