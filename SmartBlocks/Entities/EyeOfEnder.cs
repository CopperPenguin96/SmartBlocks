using MinecraftTypes;

namespace SmartBlocks.Entities
{
    public class EyeOfEnder : Entity
    {
        public override string Name => "Eye of Ender";

        public override VarInt Type => 26;

        public override bool UseSpawnEntityOnly => true;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.25, 0.25, 0.25);

        public override Identifier Identifier => new("eye_of_ender");

        public Slot Item { get; set; }
    }
}
