using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Monsters
{
    public class Ghast : Flying
    {
        public override string Name => "Ghast";

        public override VarInt Type => 30;

        public override bool UseSpawnEntityOnly => false;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(4.0, 4.0, 4.0);

        public override Identifier Identifier => new("ghast");

        public bool IsAttacking { get; set; } = false;
    }
}
