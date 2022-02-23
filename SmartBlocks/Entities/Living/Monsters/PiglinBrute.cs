using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Monsters
{
    public class PiglinBrute : BasePiglin
    {
        public override string Name => "Piglin Brute";

        public override VarInt Type => 66; // 66? Order 66?

        public override bool UseSpawnEntityOnly => false;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.6, 1.95, 0.6);

        public override Identifier Identifier => new("piglin_brute");
    }
}
