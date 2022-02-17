using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Ageable
{
    public class Chicken : Animal
    {
        public override string Name => "Chicken";

        public override VarInt Type => 10;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.4, 0.7, 0.4);

        public override Identifier Identifier => "chicken";
    }
}
