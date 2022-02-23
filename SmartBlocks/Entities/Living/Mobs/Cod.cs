using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Mobs
{
    public class Cod : AbstractFish
    {
        public override string Name => "Cod";

        public override VarInt Type => 11;

        public override bool UseSpawnEntityOnly => false;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.5, 0.3, 0.5);

        public override Identifier Identifier => "cod";
    }
}
