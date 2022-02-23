using MinecraftTypes;

namespace SmartBlocks.Entities.Arrows
{
    public class ThrownTrident : AbstractArrow
    {
        public override string Name => "Thrown Trident";

        public override VarInt Type => 93;

        public override bool UseSpawnEntityOnly => true;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.5, 0.5, 0.5);

        public override Identifier Identifier => new("trident");

        /// <summary>
        /// Per enchantment
        /// </summary>
        public VarInt LoyaltyLevel { get; set; } = 0;

        public bool HasEnchantmentGlint { get; set; } = false;
    }
}
