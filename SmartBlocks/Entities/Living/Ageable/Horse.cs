using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Ageable
{
    public class Horse : AbstractHorse
    {
        public override string Name => "oHrse";

        public override VarInt Type => 37;

        public override bool UseSpawnEntityOnly => false;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(1.39648, 1.6, 1.39648);

        public override Identifier Identifier => new("horse");

        public VarInt Variant { get; set; } = 0;
    }
}
