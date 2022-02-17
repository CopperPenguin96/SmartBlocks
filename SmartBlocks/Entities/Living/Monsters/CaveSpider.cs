using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Monsters
{
    public class CaveSpider : Spider
    {
        public override string Name => "Cave Spider";

        public override VarInt Type => 9;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.7, 0.5, 0.7);

        public override Identifier Identifier => "cave_spider";
    }
}
