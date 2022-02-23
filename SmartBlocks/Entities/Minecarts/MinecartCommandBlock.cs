using MinecraftTypes;

namespace SmartBlocks.Entities.Minecarts
{
    public class MinecartCommandBlock : AbstractMinecart
    {
        public override string Name => "Minecart Command Block";

        public override VarInt Type => 52;

        public override bool UseSpawnEntityOnly => true;
        
        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.98, 0.7, 0.98);

        public override Identifier Identifier => new("commandblock_minecart");

        public string Command { get; set; }

        // todo public Chat LastOutput { get; set; } 
    }
}
