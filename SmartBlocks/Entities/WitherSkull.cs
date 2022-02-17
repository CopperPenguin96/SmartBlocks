using MinecraftTypes;

namespace SmartBlocks.Entities
{
    public class WitherSkull : Entity
    {
        public override string Name => "Wither Skull";

        internal override bool UseSpawnEntityOnly => true;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.3125, 0.3125, 0.3125);

        public override Identifier Identifier => new("wither_skull");

        public bool IsInvulnerable { get; set; } = false;
    }
}
