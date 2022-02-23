using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Ageable
{
    public class Chicken : Animal
    {
        public override string Name => "Chicken";

        public override VarInt Type => 10;

        public override bool UseSpawnEntityOnly => false;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.4, 0.7, 0.4);

        public override Identifier Identifier => "chicken";
    }
}
