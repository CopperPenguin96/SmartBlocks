using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Mobs
{
    public class Dolphin : WaterAnimal
    {
        public override string Name => "Dolphin";

        public override VarInt Type => 14;

        public override bool UseSpawnEntityOnly => false;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.9, 0.6, 0.9);

        public override Identifier Identifier => "dolphin";

        public Position TreasurePos { get; set; } = new(0, 0, 0);

        public bool CanFindTreasure { get; set; } = false;

        public bool HasFish { get; set; } = false;
    }
}
