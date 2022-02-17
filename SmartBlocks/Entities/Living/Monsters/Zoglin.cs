using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Monsters
{
    public class Zoglin : Monster
    {
        public override string Name => "Zoglin";

        public override VarInt Type => 106;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(1.39648, 1.4, 1.39648);

        public override Identifier Identifier => new("wither_skull");

        public bool IsBaby { get; set; } = false;
    }
}
