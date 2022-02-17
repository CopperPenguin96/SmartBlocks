using MinecraftTypes;

namespace SmartBlocks.Entities
{
    public class DragonFireball : Entity
    {
        public override string Name => "Dragon Fireball";

        public override VarInt Type => 16;

        internal override bool UseSpawnEntityOnly => true;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(1.0, 1.0, 1.0);

        public override Identifier Identifier => "dragon_fireball";
    }
}
