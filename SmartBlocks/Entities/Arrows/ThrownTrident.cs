using MinecraftTypes;

namespace SmartBlocks.Entities.Arrows
{
    public class ThrownTrident : AbstractArrow
    {
        public override string Name => "Thrown Trident";

        public override VarInt Type => 93;

        internal override bool UseSpawnEntityOnly => true;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.5, 0.5, 0.5);

        public override Identifier Identifier => new("trident");

        /// <summary>
        /// Per enchantment
        /// </summary>
        public VarInt LoyaltyLevel { get; set; } = 0;

        public bool HasEnchantmentGlint { get; set; } = false;
    }
}
