using MinecraftTypes;
using SmartBlocks.Entities.Living.Villagers;

namespace SmartBlocks.Entities.Living.Monsters
{
    public class ZombieVillager : Zombie
    {
        public override string Name => "Zombie Villager";

        public override VarInt Type => 109;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.6, 1.95, 0.6);

        public override Identifier Identifier => new("zombie_villager");

        public bool IsConverting { get; set; } = false;

        public VillagerData Data { get; set; }
            = new(VillagerType.Plains, VillagerJob.None, 1);
    }
}
