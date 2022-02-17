using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Monsters
{
    public class Skeleton : AbstractSkeleton
    {
        public override string Name => "Skeleton";

        public override VarInt Type => 78;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.6, 1.99, 0.6);

        public override Identifier Identifier => new("skeleton");
    }
}
