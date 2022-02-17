﻿using MinecraftTypes;

namespace SmartBlocks.Entities.Minecarts
{
    public class MinecartChest : AbstractMinecartContainer
    {
        public override string Name => "Minecart Chest";

        public override VarInt Type => 51;

        internal override bool UseSpawnEntityOnly => true;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.98, 0.7, 0.98);

        public override Identifier Identifier => new("chest_minecart");
    }
}