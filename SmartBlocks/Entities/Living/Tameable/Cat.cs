using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Tameable
{
    public class Cat : TameableAnimal
    {
        public override string Name => "Cat";

        public override VarInt Type => 8;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.6, 0.7, 0.6);

        public override Identifier Identifier => "cat";

        public VarInt CatType { get; set; } = 1;

        public bool IsLying { get; set; } = false;

        public bool IsRelaxed { get; set; } = false;

        public VarInt CollarColor { get; set; } = 14;
    }

    public enum CatVariant
    {
        Tabby = 0,
        Black = 1,
        Red = 2,
        Siamese = 3,
        BritishShorthair = 4,
        Calico = 5,
        Persian = 6,
        Ragdoll = 7,
        White = 8,
        Jellie = 9,
        AllBlack = 10
    }
}
