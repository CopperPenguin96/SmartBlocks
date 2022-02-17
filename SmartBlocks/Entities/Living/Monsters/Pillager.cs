using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Monsters
{
    public class Pillager : AbstractIllager
    {
        public override string Name => "Pillager";

        public override VarInt Type => 67;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.6, 1.95, 0.6);

        public override Identifier Identifier => new("pillager");

        public bool IsCharging { get; set; } = false;
    }
}
