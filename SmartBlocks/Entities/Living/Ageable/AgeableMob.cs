using java.util;
using SmartBlocks.Entities.Living.Mobs;

namespace SmartBlocks.Entities.Living.Ageable;

public class AgeableMob : PathFinderMob
{
    public bool IsBaby => Age < -1;

    public bool CanBreed => !IsBaby && Age < 1;

    public int Age { get; set; }

    public int ForcedAge { get; set; }

    public int LoveTicks { get; set; }

    public UUID LoveCause { get; set; }
}