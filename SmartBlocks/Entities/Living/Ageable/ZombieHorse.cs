using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Ageable
{
    public class ZombieHorse : AbstractHorse
    {
        public override string Name => "Zombie Horse";

        public override VarInt Type => 108;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(1.39648, 1.6, 1.39648);

        public override Identifier Identifier => new("zombie_horse");
    }
}
