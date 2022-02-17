using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Monsters
{
    public class Ravager : Raider
    {
        public override string Name => "Ravager";

        public override VarInt Type => 72;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(1.95, 2.2, 1.95);

        public override Identifier Identifier => new("ravager");
    }
}
