using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Monsters
{
    public class Zoglin : Monster
    {
        public override string Name => "Zoglin";

        public override VarInt Type => 106;

        public override bool UseSpawnEntityOnly => false;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(1.39648, 1.4, 1.39648);

        public override Identifier Identifier => new("wither_skull");

        public bool IsBaby { get; set; } = false;
    }
}
