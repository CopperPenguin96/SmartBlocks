using MinecraftTypes;
using SmartBlocks.Entities.Living.Ageable;

namespace SmartBlocks.Entities.Living.Villagers
{
    public abstract class AbstractVillager : AgeableMob
    {
        public override string Name => "Abstract Villager";

        public override bool UseSpawnEntityOnly => false;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => false;

        /// <summary>
        /// Starts at 40, decrements each tick
        /// </summary>
        public VarInt HeadShakeTimer { get; set; } = 0;
    }
}
