using Medallion;
using MinecraftTypes;
using SmartBlocks.Entities.Living.Ageable;
using SmartBlocks.Entities.Living.Mobs;
using java.util;

namespace SmartBlocks.Entities.Living.Villagers;

public abstract class AbstractVillager : AgeableMob
{
    public override string Name => "Abstract Villager";

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => false;

    /// <summary>
    /// Starts at 40, decrements each tick
    /// </summary>
    public VarInt HeadShakeTimer { get; set; } = 0;

    public void AddRndSpawnBonusKnocback(double value = -1)
    {
    }
}