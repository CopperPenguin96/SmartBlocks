using SmartBlocks.Entities.Living.Mobs;

namespace SmartBlocks.Entities.Living.Ageable
{
    public class AgeableMob : PathFinderMob
    {
        public bool IsBaby { get; set; } = false;
    }
}
