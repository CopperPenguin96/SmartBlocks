using MinecraftTypes;

namespace SmartBlocks.Entities.Living
{
    public class Goat : LivingEntity
    {
        public override string Name => "Goat";

        public override VarInt Type => 34;

        public override bool UseSpawnEntityOnly => false;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(1.3, 0.9, 1.3);

        public override Identifier Identifier => new("goat");
    }
}
