using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Monsters
{
    public class Witch : Raider
    {
        public override string Name => "Witch";

        public override VarInt Type => 101;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.6, 1.95, 0.6);

        public override Identifier Identifier => new("witch");

        public bool IsDrinkingPotion { get; set; } = false;
    }
}
