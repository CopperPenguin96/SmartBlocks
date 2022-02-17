using MinecraftTypes;
using SmartBlocks.Generators;
using SmartBlocks.Utils;
using SmartNbt;
using SmartNbt.Tags;
using Position = MinecraftTypes.Position;

namespace SmartBlocks.Worlds
{
    public class Level
    {
        public readonly IGenerator Generator = new FlatGenerator();

        public const int DataVersion = 2730;

        public const int Version = 19133;

        public bool AllowCommands { get; set; } = false;

        public PosDouble BorderCenter { get; set; } = new(0, 0, 0);

        public double BorderDamagePerBlock { get; set; } = 0.2;

        public double BorderSafeZone { get; set; } = 5;

        public double BorderSize { get; set; } = 59999968;

        public double BorderSizeLerpTarget { get; set; } = 59999968;

        public TimeSpan BorderSizeLerpTime { get; set; } = new(0);

        public double BorderWarningBlocks { get; set; } = 5;

        public double BorderWarningTime { get; set; } = 15;

        public int ClearWeatherTime { get; set; } = 0;

        public TimeSpan DayTime { get; set; } = new(0);

        public Difficulty Difficulty { get; set; } = Difficulty.Normal;

        public bool DifficultyLocked { get; set; } = false;

        public GameMode GameMode { get; set; } = GameMode.Survival;

        public bool IsHardcore { get; set; } = false;

        public bool Initialized { get; set; } = false;

        public DateTime LastPlayed { get; set; } = new(0);

        public string Name { get; set; } = "New World";

        public bool IsRaining { get; set; } = false;

        public int RainTime { get; set; } = 0;

        public float SpawnAngle { get; set; } = 0;

        public Position Spawn { get; set; } = new(0, 0, 0);

        public bool IsThundering { get; set; } = false;

        public TimeSpan ThunderTime { get; set; } = new(0);

        public TimeSpan Time { get; set; } = new(0);

        public int WanderingTraderSpawnChance { get; set; } = 25;

        public int WanderingTraderSpawnDelay { get; set; } = 22800;

        public bool WasModded { get; set; } = false;

        public DragonFight DragonFight { get; set; } = new();

        public List<GameRule> GameRules = new();

        public bool BonusChest { get; set; } = false;

        public bool GenerateStructures { get; set; } = true;

        public NetherGenerator NetherGen { get; set; }

        public EndGenerator EndGenerator { get; set; }

        public Level()
        {

        }

        public Level(string levelName)
        {
            Name = levelName ?? throw new ArgumentNullException(nameof(levelName));
            // No need to call MakeRandomSeed
            // When seed is called and not set yet, gens a random one

            NetherGen = new();
            EndGenerator = new();
        }

        public Level(string levelName, IGenerator gen)
        {
            Name = levelName ?? throw new ArgumentNullException(nameof(levelName));
            Generator = gen;

            NetherGen = new();
            EndGenerator = new();
        }

        public NbtCompound Nbt
        {
            get
            {
                NbtCompound bossEvents = new("CustomBossEvents");

                NbtCompound dataPacks = new("DataPacks")
                {
                    new NbtList("Disabled", NbtTagType.String) { },
                    new NbtList("Enabled")
                    {
                        new NbtString("vanilla")
                    }
                };

                NbtList dList = new("Gateways");

                foreach (int i in DragonFight.Gateways)
                {
                    dList.Add(new NbtInt(i));
                }
                NbtCompound dragonFight = new("DragonFight")
                {
                    dList,
                    new NbtByte("DragonKilled", DragonFight.DragonKilled.ToByte()),
                    new NbtByte("NeedsStateScanning", DragonFight.NeedsStateScanning.ToByte()),
                    new NbtByte("PreviouslyKilled", DragonFight.PreviouslyKilled.ToByte())
                };

                NbtCompound gameRules = new("GameRules");

                foreach (GameRule rule in GameRules)
                {
                    gameRules.Add(
                        new NbtString(rule.Name, rule.Value.ToString()));
                }

                NbtCompound version = new("Version")
                {
                    new NbtInt("Id", DataVersion),
                    new NbtString("Name", MinecraftVersion.Current.ToString()),
                    new NbtByte("Snapshot", 0)
                };

                NbtCompound worldGenSettings = new("WorldGenSettings")
                {
                    new NbtCompound("dimensions")
                    {
                        new NbtCompound("minecraft:overworld")
                        {
                            Generator.Tag, // "generator"
                            new NbtString("type", Generator.Dimension.ToString())
                        },
                        new NbtCompound("minecraft:the_end")
                        {
                            EndGenerator.Tag,
                            new NbtString("type", EndGenerator.Dimension.ToString())
                        },
                        new NbtCompound("minecraft:the_nether")
                        {
                            NetherGen.Tag,
                            new NbtString("type", NetherGen.Dimension.ToString())
                        }
                    },
                    new NbtByte("bonus_chest", BonusChest.ToByte()),
                    new NbtByte("generate_features", GenerateStructures.ToByte()),
                    new NbtLong("seed", Generator.Seed)
                };

                NbtList scheduledEvents = new("ScheduledEvents", NbtTagType.String);

                NbtList serverBrands = new("ServerBrands")
                {
                    new NbtString("vanilla")
                };

                NbtCompound data = new("Data")
                {
                    bossEvents,
                    dataPacks,
                    dragonFight,
                    gameRules,
                    version,
                    worldGenSettings,
                    scheduledEvents,
                    serverBrands,
                    new NbtByte("allowCommands", AllowCommands.ToByte()),
                    new NbtDouble("BorderCenterX", BorderCenter.X),
                    new NbtDouble("BorderCenterZ", BorderCenter.Z),
                    new NbtDouble("BorderDamagePerBlock", BorderDamagePerBlock),
                    new NbtDouble("BorderSafeZone", BorderSafeZone),
                    new NbtDouble("BorderSize", BorderSize),
                    new NbtDouble("BorderSizeLerpTarget", BorderSizeLerpTarget),
                    new NbtLong("BorderSizeLerpTime", BorderSizeLerpTime.Ticks),
                    new NbtDouble("BorderWarningBlocks", BorderWarningBlocks),
                    new NbtDouble("BorderWarningTime", BorderWarningTime),
                    new NbtInt("clearWeatherTime", ClearWeatherTime),
                    new NbtInt("DataVersion", DataVersion),
                    new NbtLong("DayTime", DayTime.Ticks),
                    new NbtByte("Difficulty", (byte)Difficulty),
                    new NbtByte("DifficultyLocked", DifficultyLocked.ToByte()),
                    new NbtInt("GameType", (int)GameMode),
                    new NbtByte("hardcore", IsHardcore.ToByte()),
                    new NbtByte("initialized", Initialized.ToByte()),
                    new NbtLong("LastPlayed", LastPlayed.Ticks),
                    new NbtString("LevelName", Name),
                    new NbtByte("raining", IsRaining.ToByte()),
                    new NbtInt("rainTime", RainTime),
                    new NbtFloat("SpawnAngle", SpawnAngle),
                    new NbtInt("SpawnX", Spawn.X),
                    new NbtInt("SpawnY", Spawn.Y),
                    new NbtInt("SpawnZ", Spawn.Z),
                    new NbtByte("thundering", IsThundering.ToByte()),
                    new NbtInt("thunderTime", (int)ThunderTime.Ticks),
                    new NbtLong("Time", Time.Ticks),
                    new NbtInt("version", Version),
                    new NbtInt("WanderingTraderSpawnChance", WanderingTraderSpawnChance),
                    new NbtInt("WanderingTraderSpawnDelay", WanderingTraderSpawnDelay),
                    new NbtByte("WasModded", WasModded.ToByte())
                };

                return new NbtCompound(data);
            }
        }
    }
}
