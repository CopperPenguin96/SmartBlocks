using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Monsters
{
    public class Ghast : Flying
    {
        public override string Name => "Ghast";

        public override VarInt Type => 30;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(4.0, 4.0, 4.0);

        public override Identifier Identifier => new("ghast");

        public bool IsAttacking { get; set; } = false;
    }
}
