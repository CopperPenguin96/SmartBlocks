using MinecraftTypes;

namespace SmartBlocks.Entities
{
    public class EndCrystal : Entity
    {
        public override string Name => "End Crystal";

        public override VarInt Type => 19;

        public override bool UseSpawnEntityOnly => true;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(2.0, 2.0, 2.0);

        public override Identifier Identifier => "end_crystal";

        public OptBlockPos BeamTarget { get; set; } = new(false);

        public bool ShowBottom { get; set; } = true;
    }
}
