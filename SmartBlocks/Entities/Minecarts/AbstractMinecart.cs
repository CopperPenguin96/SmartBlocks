using MinecraftTypes;

namespace SmartBlocks.Entities.Minecarts
{
    public abstract class AbstractMinecart : Entity
    {
        public override string Name => "Abstract Minecart";

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => false;

        public VarInt ShakingPower { get; set; } = 0;

        public VarInt ShakingDirection { get; set; } = 1;

        public float ShakingMultiplier { get; set; } = 0.0f;

        public VarInt CustomBlockIdDamange { get; set; } = 0;

        public VarInt CustomBlockYPos { get; set; } = 6;

        public bool ShowCustomBlock { get; set; } = false;
    }
}
