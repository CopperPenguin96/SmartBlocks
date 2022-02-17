using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Ageable
{
    public class Rabbit : Animal
    {
        public override string Name => "Rabbit";

        public override VarInt Type => 71;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.4, 0.5, 0.4);

        public override Identifier Identifier => new("rabbit");

        public VarInt RabbitType { get; set; } = 0;
    }
}
