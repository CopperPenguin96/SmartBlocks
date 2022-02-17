using MinecraftTypes;

namespace SmartBlocks.Entities
{
    public class ShulkerBullet : Entity
    {
        public override string Name => "Shulker Bullet";

        public override VarInt Type => 76;

        internal override bool UseSpawnEntityOnly => true;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.3125, 0.3125, 0.3125);

        public override Identifier Identifier => new("shulker_bullet");
    }
}
