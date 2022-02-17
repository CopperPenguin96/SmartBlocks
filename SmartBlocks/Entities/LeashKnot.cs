using MinecraftTypes;

namespace SmartBlocks.Entities
{
    public class LeashKnot : Entity
    {
        public override string Name => "Leash Knot";

        public override VarInt Type => 44;

        internal override bool UseSpawnEntityOnly => true;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.375, 0.5, 0.375);

        public override Identifier Identifier => new("leash_knot");
    }
}
