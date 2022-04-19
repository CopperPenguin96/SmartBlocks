using System.Security.Cryptography.X509Certificates;
using java.util;
using MinecraftTypes;
using SmartBlocks.Utils;
using SmartBlocks.Worlds;
using SmartNbt;
using SmartNbt.Tags;

namespace SmartBlocks.Entities.Living.Mobs.Memories
{
    public abstract class Memory : ITagProvider
    {
        public virtual Identifier Id { get; }

        public virtual NbtTag Tag { get; }
    }

    public class AdmiringDisabledMemory : Memory
    {
        public override Identifier Id => new("admiring_disabled");

        public bool Value { get; set; }

        public long Ttl { get; set; }

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                new NbtBoolean("value", Value),
                new NbtLong("ttl", Ttl)
            };
    }

    public class AdmiringItemMemory : Memory
    {
        public override Identifier Id => new("admiring_item");

        public bool Value { get; set; }

        public long Ttl { get; set; }

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                new NbtBoolean("value", Value),
                new NbtLong("ttl", Ttl)
            };
    }

    public class AngryAtMemory : Memory
    {
        public override Identifier Id => new("angry_at");

        public UUID Value { get; set; }

        public long Ttl { get; set; }

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                new NbtIntArray("value", Value.ToLongArray().ToIntArray()),
                new NbtLong("ttl", Ttl)
            };
    }

    public class DigCooldownMemory : Memory
    {
        public override Identifier Id => new("dig_cooldown");

        public readonly NbtCompound Value = new("value");

        public long Ttl { get; set; }

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                Value,
                new NbtLong("ttl", Ttl)
            };
    }

    public class GolemDetectedRecentlyMemory : Memory
    {
        public override Identifier Id => new("golem_detected_recently");

        public bool Value { get; set; }

        public long Ttl { get; set; }

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                new NbtBoolean("value", Value),
                new NbtLong("ttl", Ttl)
            };
    }

    public class HasHuntingCooldownMemory : Memory
    {
        public override Identifier Id => new("has_hunting_cooldown");

        public bool Value { get; set; }

        public long Ttl { get; set; }

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                new NbtBoolean("value", Value),
                new NbtLong("ttl", Ttl)
            };
    }

    public class HomeMemory : Memory
    {
        public override Identifier Id => new("home");

        public Dimension Dimension { get; set; }

        public Position Position { get; set; }

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                new NbtCompound("value")
                {
                    new NbtString("dimension", Dimension.ToString()),
                    new NbtIntArray("pos", Position.AsArray())
                }
            };
    }

    public class HuntedRecentlyMemory : Memory
    {
        public override Identifier Id => new("hunted_recently");

        public bool Value { get; set; }

        public long Ttl { get; set; }

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                new NbtBoolean("value", Value),
                new NbtLong("ttl", Ttl)
            };
    }

    public class IsEmergingMemory : Memory
    {
        public override Identifier Id => new("is_emerging");

        public readonly NbtCompound Value = new("value");

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                Value
            };
    }

    public class IsInWaterMemory : Memory
    {
        public override Identifier Id => new("is_in_water");

        public readonly NbtCompound Value = new("value");

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                Value
            };
    }

    public class IsPregnant : Memory
    {
        public override Identifier Id => new("is_pregnant");

        public readonly NbtCompound Value = new("value");

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                Value
            };
    }

    public class IsSniffing : Memory
    {
        public override Identifier Id => new("is_sniffing");

        public readonly NbtCompound Value = new("value");

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                Value
            };
    }

    public class IsTemptedMemory : Memory
    {
        public override Identifier Id => new("is_tempted");

        public bool IsTempted { get; set; }

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                new NbtBoolean("value", IsTempted)
            };
    }

    public class ItemPickupCooldownTicksMemory : Memory
    {
        public override Identifier Id => new("item_pickup_cooldown_ticks");
        
        public int Value { get; set; }

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                new NbtInt("value", Value)
            };
    }

    public class JobSiteMemory : Memory
    {
        public override Identifier Id => new("job_site");
        
        public Dimension Dimension { get; set; }

        public Position Position { get; set; }

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                new NbtCompound("value")
                {
                    new NbtString("dimension", Dimension.ToString()),
                    new NbtIntArray("pos", Position.AsArray())
                }
            };
    }

    public class LastSleptMemory : Memory
    {
        public override Identifier Id => new("last_slept");

        public long Value { get; set; }

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                new NbtLong("value", Value)
            };
    }

    public class LastWokenMemory : Memory
    {
        public override Identifier Id => new("last_woken");

        public long Value { get; set; }

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                new NbtLong("value", Value)
            };
    }

    public class LastWorkedAtPoMemory : Memory
    {
        public override Identifier Id => new("last_worked_at_poi");

        public long Value { get; set; }

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                new NbtLong("value", Value)
            };
    }

    public class LikedNoteblockMemory : Memory
    {
        public override Identifier Id => new("liked_noteblock");

        public Dimension Dimension { get; set; }

        public Position Position { get; set; }

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                new NbtCompound("value")
                {
                    new NbtString("dimension", Dimension.ToString()),
                    new NbtIntArray("pos", Position.AsArray())
                }
            };
    }

    public class LikedNoteblockCooldownTicksMemory : Memory
    {
        public override Identifier Id => new("liked_noteblock_cooldown_ticks");

        public int Value { get; set; }

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                new NbtInt("value", Value)
            };
    }

    public class LikedPlayerMemory : Memory
    {
        public override Identifier Id => new("last_worked_at_poi");

        public UUID UniqueId { get; set; }

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                new NbtIntArray("value", UniqueId.GetIntArray())
            };
    }

    public class LongJumpCoolingDownMemory : Memory
    {
        public override Identifier Id => new("long_jump_cooling_down");

        public int Value { get; set; }

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                new NbtInt("value", Value)
            };
    }

    public class MeetingPointMemory : Memory
    {
        public override Identifier Id => new("meeting_point");

        public Dimension Dimension { get; set; }

        public Position Position { get; set; }

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                new NbtCompound("value")
                {
                    new NbtString("dimension", Dimension.ToString()),
                    new NbtIntArray("pos", Position.AsArray())
                }
            };
    }

    public class PlayDeadTicksMemory : Memory
    {
        public override Identifier Id => new("play_dead_ticks");

        public long Value { get; set; }

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                new NbtInt("value")
            };
    }

    public class PotentialJobSiteMemory : Memory
    {
        public override Identifier Id => new("potential_job_site");

        public Dimension Dimension { get; set; }

        public Position Position { get; set; }

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                new NbtCompound("value")
                {
                    new NbtString("dimension", Dimension.ToString()),
                    new NbtIntArray("pos", Position.AsArray())
                }
            };
    }

    public class RamCooldownTicksMemory : Memory
    {
        public override Identifier Id => new("ram_cooldown_ticks");

        public long Value { get; set; }

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                new NbtInt("value")
            };
    }

    public class RecentProjectileMemory : Memory
    {
        public override Identifier Id => new("recent_projectile");

        public readonly NbtCompound Value = new();

        public long Ttl { get; set; }

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                Value,
                new NbtLong("ttl", Ttl)
            };
    }

    public class RoarSoundCooldownMemory : Memory
    {
        public override Identifier Id => new("roar_sound_cooldown");

        public readonly NbtCompound Value = new();

        public long Ttl { get; set; }

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                Value,
                new NbtLong("ttl", Ttl)
            };
    }

    public class RoarSoundDelayMemory : Memory
    {
        public override Identifier Id => new("roar_sound_delay");

        public readonly NbtCompound Value = new();

        public long Ttl { get; set; }

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                Value,
                new NbtLong("ttl", Ttl)
            };
    }

    public class SniffCooldownMemory : Memory
    {
        public override Identifier Id => new("sniff_cooldown");

        public readonly NbtCompound Value = new();

        public long Ttl { get; set; }

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                Value,
                new NbtLong("ttl", Ttl)
            };
    }

    public class TemptationCooldownTicksMemory : Memory
    {
        public override Identifier Id => new("temptation_cooldown_ticks");

        public int Value { get; set; }

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                new NbtInt("value", Value)
            };
    }

    public class TouchCooldownMemory : Memory
    {
        public override Identifier Id => new("touch_cooldown");

        public readonly NbtCompound Value = new();

        public long Ttl { get; set; }

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                Value,
                new NbtLong("ttl", Ttl)
            };
    }

    public class UniversalAngerMemory : Memory
    {
        public override Identifier Id => new("universal_anger");

        public bool Value { get; set; }

        public long Ttl { get; set; }

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                new NbtBoolean("value", Value),
                new NbtLong("ttl", Ttl)
            };
    }

    public class VibrationCooldownMemory : Memory
    {
        public override Identifier Id => new("vibration_cooldown");

        public readonly NbtCompound Value = new();

        public long Ttl { get; set; }

        public override NbtTag Tag =>
            new NbtCompound(Id.ToString())
            {
                Value,
                new NbtLong("ttl", Ttl)
            };
    }
}
