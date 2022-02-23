using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Ageable
{
    public class PolarBear : Animal
    {
        public override string Name => "Polar Bear";

        public override VarInt Type => 68;

        public override bool UseSpawnEntityOnly => false;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(1.4, 1.4, 1.4);

        public override Identifier Identifier => new("polar_bear");

        public bool IsStandingUp { get; set; } = false;
    }
}
