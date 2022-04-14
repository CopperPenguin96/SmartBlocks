using System.Diagnostics.CodeAnalysis;
// ReSharper disable StaticMemberInGenericType

namespace SmartBlocks.Utils;

public class GameRule : GameRule<object>
{
    public GameRule(string name) : base(name)
    {
    }

    public GameRule(string name, object value) : base(name, value)
    {
    }

    public GameRule(GameRule<int> gInt)
    {
        Name = gInt.Name;
        Value = gInt.Value;
    }

    public GameRule(GameRule<string> gStr)
    {
        Name = gStr.Name;
        Value = gStr.Value;
    }

    public GameRule(GameRule<bool> gBool)
    {
        Name = gBool.Name;
        Value = gBool.Value;
    }

    public GameRule(GameRule<int> gInt, int value)
    {
        Name = gInt.Name;
        Value = value;
    }

    public GameRule(GameRule<string> gStr, string value)
    {
        Name = gStr.Name;
        Value = value;
    }

    public GameRule(GameRule<bool> gBool, bool value)
    {
        Name = gBool.Name;
        Value = value;
    }
}

public class GameRule<T>
{
    [NotNull] public string Name { get; protected set; }

    [NotNull] public T Value { get; set; }

    protected GameRule() { }

    public GameRule(string name)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }

    public GameRule(string name, T value) : this(name)
    {
        Value = value;
    }

    /// <summary>
    /// Whether advancements should be announced in chat.
    /// </summary>
    public static readonly GameRule<bool> AnnounceAdvancements =
        new("announceAdvancements", true);

    /// <summary>
    /// Whether command blocks should notify admins when they
    /// perform commands
    /// </summary>
    public static readonly GameRule<bool> CommandBlockOutput =
        new("commandBlockOutput", true);

    /// <summary>
    /// Whether the server should skip checking player speed when the
    /// player is wearing elytra. Often helps with jittering due to lag
    /// in multiplayer.
    /// </summary>
    public static readonly GameRule<bool> DisableElytraMovementChest =
        new("disableElytraMovementCHeck", false);

    /// <summary>
    /// Whether raids are disabled.
    /// </summary>
    public static readonly GameRule<bool> DisableRaids =
        new("disableRaids", false);

    /// <summary>
    /// Whether the daylight cycle and moon phases progress.
    /// </summary>
    public static readonly GameRule<bool> DoDaylightCycle =
        new("doDaylightCycle", true);

    /// <summary>
    /// Whether entities that are not mobs should have drops.
    /// </summary>
    public static readonly GameRule<bool> DoEntityDrops =
        new("doEntityDrops", true);

    /// <summary>
    /// Whether fire should spread and naturally extinguish.
    /// </summary>
    public static readonly GameRule<bool> DoFireTick =
        new("doFireTick", true);

    /// <summary>
    /// Whether phantoms can spawn in the nighttime.
    /// </summary>
    public static readonly GameRule<bool> DoInsomnia =
        new("doInsomnia", true);

    /// <summary>
    /// Players respawn immediately without showing the death screen.
    /// </summary>
    public static readonly GameRule<bool> DoImmediateRespawn =
        new("doImmediateRespawn", false);

    /// <summary>
    /// Whether players should be able to craft only those recipes
    /// that they've unlocked first.
    /// </summary>
    public static readonly GameRule<bool> DoLimitedCrafting =
        new("doLimitedCrafting", false);

    /// <summary>
    /// Whether mobs should drop items and experience orbs.
    /// </summary>
    public static readonly GameRule<bool> DoMobLoot =
        new("doMobLoot", true);

    /// <summary>
    /// Whether mobs should naturally spawn. Does not affect
    /// monster spawners.
    /// </summary>
    public static readonly GameRule<bool> DoMobSpawning =
        new("doMobSpawning", true);

    /// <summary>
    /// Whether patrols can spawn.
    /// </summary>
    public static readonly GameRule<bool> DoPatrolSpawning =
        new("doPatrolSpawning", true);

    /// <summary>
    /// Whether blocks should have drops.
    /// </summary>
    public static readonly GameRule<bool> DoTileDrops =
        new("doTileDrops", true);

    /// <summary>
    /// Whether wandering traders can spawn.
    /// </summary>
    public static readonly GameRule<bool> DoTraderSpawning =
        new("doTraderSpawning", true);

    /// <summary>
    /// Whether the weather can change naturally. The /weather command
    /// can still change the weather.
    /// </summary>
    public static readonly GameRule<bool> DoWeatherCycle =
        new("doWeatherCycle", true);

    /// <summary>
    /// Whether the player should take damage when drowning.
    /// </summary>
    public static readonly GameRule<bool> DrowningDamage =
        new("drowningDamage", true);

    /// <summary>
    /// Whether the player should take fall damage.
    /// </summary>
    public static readonly GameRule<bool> FallDamage =
        new("fallDamage", true);

    /// <summary>
    /// Whether the player should take damage in fire, lava, campfires,
    /// or on magma blocks.
    /// </summary>
    public static readonly GameRule<bool> FireDamage =
        new("fireDamage", true);

    /// <summary>
    /// Makes angered neutral mobs stop being angry when the
    /// targeted player dies nearby.
    /// </summary>
    public static readonly GameRule<bool> ForgiveDeadPlayers =
        new("forgiveDeadPlayers", true);

    /// <summary>
    /// Whether the player should take damage when inside powder snow.
    /// </summary>
    public static readonly GameRule<bool> FreezeDamage =
        new("freezeDamage", true);

    /// <summary>
    /// Whether the player should keep items and experience in their
    /// inventory after death.
    /// </summary>
    public static readonly GameRule<bool> KeepInventory =
        new("keepInventory", false);

    /// <summary>
    /// Whether to log admin commands to server log.
    /// </summary>
    public static readonly GameRule<bool> LogAdminCommands =
        new("logAdminCommands", true);

    /// <summary>
    /// The maximum length of a chain of commands that can be executed
    /// during one tick. Applies to command blocks and functions.
    /// </summary>
    public static readonly GameRule<int> MaxCommandChainLength =
        new("maxCommandChainLength", 65536);

    /// <summary>
    /// The maximum number of pushable entities a mob or player can push,
    /// before taking 3 suffocation damage per half-second. Setting to 0
    /// or lower disables this rule. Damage affects survival-mode or
    /// adventure-mode players, and all mobs but bats. Pushable entites
    /// include non-spectator-mode players, any mob except bats, as well
    /// as boats and minecarts.
    /// </summary>
    public static readonly GameRule<int> MaxEntityCramming =
        new("maxEntityCramming", 24);

    /// <summary>
    /// Whether creepers, zombies, endermen, ghasts, withers, ender
    /// dragons, rabbits, sheep, villagers, silverfish, snow golems,
    /// and end crystals should be able to change blocks and whether mobs
    /// can pick up items, which also disables bartering. This also affects
    /// the capability of zombie-like creatures like zombified piglins and
    /// drowned to pathfind to turtle eggs.
    /// </summary>
    public static readonly GameRule<bool> MobGriefing =
        new("mobGriefing", true);

    /// <summary>
    /// Whether the player can regenerate health naturally if their hunger
    /// is full enough (doesn't affect external healing, such as golden
    /// apples, the Regeneration effect, etc).
    /// </summary>
    public static readonly GameRule<bool> NaturalRegeneration =
        new("naturalRegeneration", true);

    /// <summary>
    /// What percentage of players must sleep to skip the night.
    /// </summary>
    public static readonly GameRule<int> PlayersSleepingPercentage =
        new("playersSleepingPercentage", 100);

    /// <summary>
    /// How often a random block tick occurs (such as plant growth, leaf
    /// decay, etc.) per chunk section per game tick. 0 and negative values
    /// disables random ticks, higher numbers increase random ticks. Setting
    /// to a high integer results in high speeds of decay and growth.
    /// Numbers over 4096 make plant growth or leaf decay instantaneous.
    /// </summary>
    public static readonly GameRule<int> RandomTickSpeed =
        new("randomTickSpeed", 3);

    /// <summary>
    /// Whether the debug screen shows all or reduced information; and
    /// whether the effects of F3 + B (entity hitboxes) and F3 + G (chunk
    /// boundaries) are shown.
    /// </summary>
    public static readonly GameRule<bool> ReducedDebugInfo =
        new("reducedDebugInfo", false);

    /// <summary>
    /// Whether the feedback from commands executed by a player should show
    /// up in a chat. Also affects the default behavior of whether command
    /// blocks store their output text.
    /// </summary>
    public static readonly GameRule<bool> SendCommandFeedback =
        new("sendCommandFeedback", true);

    /// <summary>
    /// Whether death messages are put into chat when a player dies. Also
    /// affects whether a message is sent to the pet's owner when the pet
    /// dies.
    /// </summary>
    public static readonly GameRule<bool> ShowDeathMessages =
        new("showDeathMessages", true);

    /// <summary>
    /// The number of blocks outward from the world spawn coordinates that a
    /// player spawns in when first joining a server or when dying without
    /// a personal spawnpoint.
    /// </summary>
    public static readonly GameRule<int> SpawnRadius =
        new("spawnRadius", 10);

    /// <summary>
    /// Makes angered neutral mobs attack any nearby player, not just the
    /// player that angered them. Works best if forgiveDeadPlayers is
    /// disabled.
    /// </summary>
    public static readonly GameRule<bool> UniversalAnger =
        new("universalAnger", false);
}