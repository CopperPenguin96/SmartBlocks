using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Villagers
{
    public class VillagerData
    {
        public VillagerType Type { get; set; }

        public VillagerJob Job { get; set; }

        public VarInt Level { get; set; }

        public VillagerData(VillagerType type, VillagerJob job, VarInt level)
        {
            Type = type;
            Job = job;
            Level = level;
        }
    }

    public enum VillagerType
    {
        Desert = 0,
        Jungle = 1,
        Plains = 2,
        Savanna = 3,
        Snow = 4,
        Swamp = 5,
        Taiga = 6
    }

    public enum VillagerJob
    {
        None = 0, // bums
        Armorer = 1,
        Butcher = 2,
        Cartographer = 3,
        Cleric = 4,
        Farmer = 5,
        Fisherman = 6,
        Fletcher = 7,
        Leatherworker = 8,
        Librarian = 9,
        Mason = 10,
        Nitwit = 11, // hahaha
        Shepherd = 12,
        Toolsmith = 13,
        Weaponsmith = 14
    }
}
