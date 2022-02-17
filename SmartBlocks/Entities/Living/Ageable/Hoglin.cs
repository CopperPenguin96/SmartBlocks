using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Ageable
{
    public class Hoglin : Animal
    {
        public override string Name => "Hoglin";

        public override VarInt Type => 36;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(1.39648, 1.4, 1.39648);

        public override Identifier Identifier => new("hoglin");

        public bool IsZombieImmune { get; set; } = false;
    }
}
