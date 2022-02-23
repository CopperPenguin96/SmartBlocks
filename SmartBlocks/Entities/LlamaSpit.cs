using MinecraftTypes;

namespace SmartBlocks.Entities
{
    public class LlamaSpit : Entity
    {
        public override string Name => "Llama Spit";

        public override VarInt Type => 47;

        public override bool UseSpawnEntityOnly => true;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.25, 0.25, 0.25);

        public override Identifier Identifier => new("llama_spit");
    }
}
