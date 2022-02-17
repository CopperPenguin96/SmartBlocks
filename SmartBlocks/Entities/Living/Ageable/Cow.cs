using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Ageable
{
    public class Cow : Animal
    {
        public override string Name => "Cow";

        public override VarInt Type => 12;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.9, 0.6, 0.9);

        public override Identifier Identifier => "cow";
    }
}
