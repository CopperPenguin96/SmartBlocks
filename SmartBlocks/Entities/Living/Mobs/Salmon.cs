using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Mobs
{
    public class Salmon : AbstractFish
    {
        public override string Name => "Salmon";

        public override VarInt Type => 73;

        public override bool UseSpawnEntityOnly => false;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.7, 0.4, 0.7);

        public override Identifier Identifier => new("salmon");
    }
}
