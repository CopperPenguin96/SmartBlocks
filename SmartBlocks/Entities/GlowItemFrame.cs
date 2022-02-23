using MinecraftTypes;

namespace SmartBlocks.Entities
{
    public class GlowItemFrame : Entity
    {
        public override string Name => "Glow Item Frame";

        public override VarInt Type => 32;

        public override bool UseSpawnEntityOnly => true;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.75, 0.75, 0.75);

        public override Identifier Identifier => new("glow_item_frame");
    }
}
