using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Monsters
{
    public class ZombifiedPiglin : Zombie
    {
        public override string Name => "Zombified Piglin";

        public override VarInt Type => 110;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.6, 1.8, 0.6);

        public override Identifier Identifier => new("zombified_piglin");
    }
}
