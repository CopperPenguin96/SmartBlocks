using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Ageable
{
    /// <summary>
    /// Genesis 49:14 (KJV). Read it. You'll understand.
    /// </summary>
    public class Donkey : ChestedHorse
    {
        public override string Name => "Donkey";

        public override VarInt Type => 15;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(1.5, 1.39648, 1.5);

        public override Identifier Identifier => "donkey";
    }
}
