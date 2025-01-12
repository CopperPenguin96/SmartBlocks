﻿using MinecraftTypes;
using SmartBlocks.Entities.Flags;
using SmartBlocks.Utils;

namespace SmartBlocks.Entities.Living.Mobs;

public class IronGolem : AbstractGolem
{
    public override string Name => "Iron Golem";

    public override VarInt Type => 40;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.25, 0.25, 0.25);

    public override Identifier Identifier => new("iron_golem");

    private byte _iron = 0;

    public bool IsPlayerCreated
    {
        get => FlagsHelper.IsSet(_iron, (byte) IronGolemFlag.PlayerCreated);
        set
        {
            if (value) FlagsHelper.Set(ref _iron, (byte) IronGolemFlag.PlayerCreated);
            else FlagsHelper.Unset(ref _iron, (byte) IronGolemFlag.PlayerCreated);
        }
    }
    
}