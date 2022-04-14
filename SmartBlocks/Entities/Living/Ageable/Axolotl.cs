using MinecraftTypes;
using SmartNbt.Tags;

namespace SmartBlocks.Entities.Living.Ageable;

public class Axolotl : Animal // This legit sounds like when I stuff a hot pizza roll in my mouth
{
    public override string Name => "Axolotl";

    public override VarInt Type => 3;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(1.3, 0.6, 1.3);

    public override Identifier Identifier => "axolotl";

    public AxolotlVariant Variant { get; set; } = 0;

    public bool IsPlayingDead { get; set; } = false;

    public bool IsSpawnedFromBucket { get; set; } = false;

    public override NbtTag Tag
    {
        get
        {
            NbtCompound start = (NbtCompound) base.Tag;

            start.Add(new NbtInt("Age", Age));
            start.Add(new NbtInt("ForcedAge", ForcedAge));
            start.Add(new NbtInt("InLove", LoveTicks));
            start.Add(new NbtIntArray("LoveCause", new int[]
            {
                (int) LoveCause.getMostSignificantBits(),
                (int) LoveCause.getLeastSignificantBits()
            }));

            return start;
        }
    }
}