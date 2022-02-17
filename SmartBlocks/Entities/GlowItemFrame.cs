using MinecraftTypes;

namespace SmartBlocks.Entities
{
    public class GlowItemFrame : Entity
    {
        public override string Name => "Glow Item Frame";

        public override VarInt Type => 32;

        internal override bool UseSpawnEntityOnly => true;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.75, 0.75, 0.75);

        public override Identifier Identifier => new("glow_item_frame");
    }
}
