using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Villagers
{
    public class Villager : AbstractVillager
    {
        public override string Name => "Villager";

        public override VarInt Type => 98;

        public override bool UseSpawnEntityOnly => false;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.6, 1.95, 0.6);

        public override Identifier Identifier => new("villager");

        public VillagerData Data { get; set; }
            = new(VillagerType.Plains, VillagerJob.None, 1);
    }
}
