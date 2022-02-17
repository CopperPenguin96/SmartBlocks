using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Mobs
{
    public class Cod : AbstractFish
    {
        public override string Name => "Cod";

        public override VarInt Type => 11;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.5, 0.3, 0.5);

        public override Identifier Identifier => "cod";
    }
}
