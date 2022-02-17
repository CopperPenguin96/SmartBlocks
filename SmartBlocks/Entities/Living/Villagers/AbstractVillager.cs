using MinecraftTypes;
using SmartBlocks.Entities.Living.Ageable;

namespace SmartBlocks.Entities.Living.Villagers
{
    public abstract class AbstractVillager : AgeableMob
    {
        public override string Name => "Abstract Villager";

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => false;

        /// <summary>
        /// Starts at 40, decrements each tick
        /// </summary>
        public VarInt HeadShakeTimer { get; set; } = 0;
    }
}
