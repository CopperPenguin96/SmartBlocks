using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Monsters
{
    public class ZombifiedPiglin : Zombie
    {
        public override string Name => "Zombified Piglin";

        public override VarInt Type => 110;

        public override bool UseSpawnEntityOnly => false;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.6, 1.8, 0.6);

        public override Identifier Identifier => new("zombified_piglin");
    }
}
