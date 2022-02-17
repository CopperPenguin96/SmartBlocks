using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Monsters
{
    public class Piglin : BasePiglin
    {
        public override string Name => "Piglin";

        public override VarInt Type => 65;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.6, 0.9, 0.6);

        public override Identifier Identifier => new("piglin");

        public bool IsBaby { get; set; } = false;

        public bool IsChargingCrossbow { get; set; } = false;

        public bool IsDancing { get; set; } = false;
    }
}
