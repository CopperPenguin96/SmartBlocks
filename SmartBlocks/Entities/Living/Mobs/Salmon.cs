using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Mobs
{
    public class Salmon : AbstractFish
    {
        public override string Name => "Salmon";

        public override VarInt Type => 73;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.7, 0.4, 0.7);

        public override Identifier Identifier => new("salmon");
    }
}
