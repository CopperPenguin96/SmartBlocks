using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Ageable
{
    public class Axolotl : Animal // This legit sounds like when I stuff a hot pizza roll in my mouth
    {
        public override string Name => "Axolotl";

        public override VarInt Type => 3;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(1.3, 0.6, 1.3);

        public override Identifier Identifier => "axolotl";

        public AxolotlVariant Variant { get; set; } = 0;

        public bool IsPlayingDead { get; set; } = false;

        public bool IsSpawnedFromBucket { get; set; } = false;
    }

    public enum AxolotlVariant
    {
        Lucy = 0,
        Wild = 1,
        Gold = 2,
        Cyan = 3,
        Blue = 4
    }
}
