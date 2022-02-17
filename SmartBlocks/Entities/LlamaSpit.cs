using MinecraftTypes;

namespace SmartBlocks.Entities
{
    public class LlamaSpit : Entity
    {
        public override string Name => "Llama Spit";

        public override VarInt Type => 47;

        internal override bool UseSpawnEntityOnly => true;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.25, 0.25, 0.25);

        public override Identifier Identifier => new("llama_spit");
    }
}
