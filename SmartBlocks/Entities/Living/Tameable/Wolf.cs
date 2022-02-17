using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Tameable
{
    public class Wolf : TameableAnimal
    {
        public override string Name => "Wolf";

        public override VarInt Type => 105;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.6, 0.85, 0.6);

        public override Identifier Identifier => new("wolf");

        public bool IsBegging { get; set; }

        public VarInt CollarColor { get; set; } = 14;

        public VarInt AngerTime { get; set; } = 0;
    }
}
