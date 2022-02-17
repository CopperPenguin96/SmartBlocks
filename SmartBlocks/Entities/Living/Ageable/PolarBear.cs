using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Ageable
{
    public class PolarBear : Animal
    {
        public override string Name => "Polar Bear";

        public override VarInt Type => 68;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(1.4, 1.4, 1.4);

        public override Identifier Identifier => new("polar_bear");

        public bool IsStandingUp { get; set; } = false;
    }
}
