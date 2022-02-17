using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Mobs
{
    public class Shulker : AbstractGolem
    {
        public override string Name => "Shulker";

        public override VarInt Type => 75;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(1.0, 2.0, 1.0);

        public override Identifier Identifier => new("shulker");

        public Direction AttachFaceDirection { get; set; } = Direction.Down;

        public OptObject<Position> AttachmentPos { get; set; }

        public byte ShieldHeight { get; set; } = 0;

        public byte Color { get; set; } = 10;
    }
}
