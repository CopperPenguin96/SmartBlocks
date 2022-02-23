using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Tameable
{
    public class Wolf : TameableAnimal
    {
        public override string Name => "Wolf";

        public override VarInt Type => 105;

        public override bool UseSpawnEntityOnly => false;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.6, 0.85, 0.6);

        public override Identifier Identifier => new("wolf");

        public bool IsBegging { get; set; }

        public VarInt CollarColor { get; set; } = 14;

        public VarInt AngerTime { get; set; } = 0;
    }
}
