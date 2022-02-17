using MinecraftTypes;

namespace SmartBlocks.Entities
{
    public class FallingBlock : Entity
    {
        public Position SpawnPosition { get; set; } = new(0, 0, 0);

        public override string Name => "Falling Block";

        public override VarInt Type => 27;

        internal override bool UseSpawnEntityOnly => true;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.98, 0.98, 0.98);

        public override Identifier Identifier => new("falling_block");

        public World World { get; set; }
    }
}
