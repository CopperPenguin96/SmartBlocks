using java.util;
using MinecraftTypes;
using SmartNbt;
using SmartNbt.Tags;

namespace SmartBlocks.Worlds.Raids;

public class Raid : ITagProvider
{
    /// <summary>
    /// Whether the raid functionality is active.
    /// </summary>
    public bool Active { get; set; }

    /// <summary>
    /// The level of bad omen for the raid.
    /// Affects raider enchantments and the
    /// extra wave.
    /// </summary>
    public int BadOmenLevel { get; set; }

    /// <summary>
    /// The Position of the center of the raid,
    /// where raiders try to move to.
    /// </summary>
    public Position Center { get; set; }

    /// <summary>
    /// The number of waves that have spawned
    /// in the raid.
    /// </summary>
    public int GroupsSpawned { get; set; }

    /// <summary>
    /// "Heroes of the Village"
    /// A list of players who have killed raiders
    /// in the raid. Each of these players receives
    /// the hero of the village effect when the raid
    /// enters in a victory status.
    /// </summary>
    public List<UUID> Heroes { get; set; }

    /// <summary>
    /// The ID of the raid.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The total number of waves in this raid.
    /// </summary>
    public int Waves { get; set; }

    /// <summary>
    /// The timespan until the initial spawning of raiders
    /// </summary>
    public TimeSpan PreRaidTime { get; set; }

    /// <summary>
    /// The timepsan after all the waves are cleared
    /// </summary>
    public TimeSpan PostRaidTime { get; set; }

    /// <summary>
    /// True if the raid has ever spawned a wave.
    /// </summary>
    public bool Started { get; set; }

    /// <summary>
    /// The status of the raid.
    /// </summary>
    public RaidStatus Status { get; set; }

    /// <summary>
    /// The timespan the raid has been going on for
    /// </summary>
    public TimeSpan ActiveTime { get; set; }

    /// <summary>
    /// The sum of max health of all the raiders in
    /// the current wave.
    /// </summary>
    public float TotalHealth { get; set; }


    public NbtTag Tag
    {
        get
        {
            // Gather heroes ... Heroes ASSEMBLE
            NbtList heroes = new("HeroesOfTheVillaged", NbtTagType.Compound);
            foreach (UUID uid in Heroes)
            {
                heroes.Add(new NbtCompound
                {
                    new NbtLong("UUIDLeast", uid.getLeastSignificantBits()),
                    new NbtLong("UUIDMost", uid.getMostSignificantBits())
                });
            }
                
            // Build Nbt
            return new NbtCompound
            {
                new NbtBoolean("Active", Active),
                new NbtInt("BadOmenLevel", BadOmenLevel),
                new NbtInt("CX", Center.X),
                new NbtInt("CY", Center.Y),
                new NbtInt("CZ", Center.Z),
                new NbtInt("GroupsSpawned", GroupsSpawned),
                heroes,
                new NbtInt("Id", Id),
                new NbtInt("NumGroups", Waves),
                new NbtInt("PreRaidTicks", (int) PreRaidTime.Ticks),
                new NbtInt("PostRaidTicks", (int) PostRaidTime.Ticks),
                new NbtBoolean("Started", Started),
                new NbtString("Status", Status.ToString()),
                new NbtLong("TicksActive", ActiveTime.Ticks),
                new NbtFloat("TotalHealth", TotalHealth)
            };
        }
    }
}