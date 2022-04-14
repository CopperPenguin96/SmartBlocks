using java.util;
using MinecraftTypes;
using SmartBlocks.Entities.Attributes;
using SmartBlocks.Entities.Flags;
using SmartBlocks.Entities.Living.Mobs;
using SmartBlocks.Entities.Particles;
using SmartBlocks.Utils;
using SmartBlocks.Worlds;
using SmartNbt;
using SmartNbt.Tags;

namespace SmartBlocks.Entities;

public abstract class Entity : ITagProvider
{
    public VarInt Id { get; set; }

    public virtual VarInt Type { get; }

    public UUID UniqueId { get; set; }

    public virtual string Name => "Entity";

    public MobAttributeList Attributes { get; set; }

    /// <summary>
    /// Adds an attribute with the default base
    /// </summary>
    /// <param name="type"></param>
    public void AddAttribute(Identifier type)
    {
        Attributes.Add(Attributes[type]);
    }

    /// <summary>
    /// Adds an attribute with the specified base.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bs"></param>
    public void AddAttribute(Identifier type, double bs)
    {
        MobAttribute attribute = Attributes[type];
        Attributes.Add(attribute);
    }

    public virtual bool UseSpawnEntityOnly { get; }

    public virtual bool UseSpawnPaintingOnly { get; }

    public virtual bool UseSpawnXpOnly { get; }

    public virtual bool AllowedSpawn { get; }

    public Position Velocity { get; set; }

    public PosDouble Position { get; set; }

    public byte HeadPitch { get; set; }

    public virtual BoundingBox BoundingBox { get; set; }

    public virtual Identifier Identifier { get; }

    public VarInt AirTicks { get; set; } = 300;

    // todo OptChatBuilder
    public OptObject<string> CustomName { get; set; }

    public bool IsSilent { get; set; } = false;

    public bool HasNoGravity { get; set; } = false;

    public Pose Pose { get; set; } = Pose.Standing;

    public VarInt TicksFrozenInPoweredSnow { get; set; } = 0;

    public short FireLeft { get; set; } = -20;

    public float FallDistance { get; set; }

    public bool IsInvulnerable { get; set; }

    public PosDouble MotionVelocity { get; set; }

    public bool OnGround { get; set; }

    public List<Entity> Riders { get; set; }

    public int PortalCooldown { get; set; } = 0;

    #region Flags

    private byte _entityMask = 0;

    public bool IsOnFire
    {
        get => FlagsHelper.IsSet(_entityMask, (byte) EntityFlag.OnFire);
        set
        {
            if (value) FlagsHelper.Set(ref _entityMask, (byte) EntityFlag.OnFire);
            else FlagsHelper.Unset(ref _entityMask, (byte) EntityFlag.OnFire);
        }
    }

    public bool IsCrouching
    {
        get => FlagsHelper.IsSet(_entityMask, (byte) EntityFlag.Crouching);
        set
        {
            if (value) FlagsHelper.Set(ref _entityMask, (byte) EntityFlag.Crouching);
            else FlagsHelper.Unset(ref _entityMask, (byte) EntityFlag.Crouching);
        }
    }

    public bool IsSprinting
    {
        get => FlagsHelper.IsSet(_entityMask, (byte) EntityFlag.Sprinting);
        set
        {
            if (value) FlagsHelper.Set(ref _entityMask, (byte) EntityFlag.Sprinting);
            else FlagsHelper.Unset(ref _entityMask, (byte) EntityFlag.Sprinting);
        }
    }

    public bool IsSwimming
    {
        get => FlagsHelper.IsSet(_entityMask, (byte) EntityFlag.Swimming);
        set
        {
            if (value) FlagsHelper.Set(ref _entityMask, (byte) EntityFlag.Swimming);
            else FlagsHelper.Unset(ref _entityMask, (byte) EntityFlag.Swimming);
        }
    }

    public bool IsInvisible
    {
        get => FlagsHelper.IsSet(_entityMask, (byte) EntityFlag.Invisible);
        set
        {
            if (value) FlagsHelper.Set(ref _entityMask, (byte) EntityFlag.Invisible);
            else FlagsHelper.Unset(ref _entityMask, (byte) EntityFlag.Invisible);
        }
    }

    public bool HasGlowingEffect
    {
        get => FlagsHelper.IsSet(_entityMask, (byte) EntityFlag.Glowing);
        set
        {
            if (value) FlagsHelper.Set(ref _entityMask, (byte) EntityFlag.Glowing);
            else FlagsHelper.Unset(ref _entityMask, (byte) EntityFlag.Glowing);
        }
    }

    public bool FlyingWithElytra
    {
        get => FlagsHelper.IsSet(_entityMask, (byte) EntityFlag.FlyingElytra);
        set
        {
            if (value) FlagsHelper.Set(ref _entityMask, (byte) EntityFlag.FlyingElytra);
            else FlagsHelper.Unset(ref _entityMask, (byte) EntityFlag.FlyingElytra);
        }
    }

    #endregion

    public virtual void Spawn()
    {
        throw new NotImplementedException();
    }

    public virtual NbtTag Tag
    {
        get
        {
            // Pull together all the piggybackers
            NbtList riders = new("Passengers");
            foreach (Entity entity in Riders)
            {
                riders.Add(entity.Tag);
            }

            // Build the nbt
            NbtCompound entityData = new()
            {
                new NbtShort("Air", AirTicks),
                new NbtString("CustomName", CustomName.Value!),
                new NbtBoolean("CustomNameVisible", CustomName.Enabled),
                new NbtFloat("FallDistance", FallDistance),
                new NbtShort("Fire", FireLeft),
                new NbtBoolean("Glowing", HasGlowingEffect),
                new NbtBoolean("HasVisualFire", IsOnFire),
                new NbtString("id", Id.ToString()),
                new NbtBoolean("Invulnerable", IsInvulnerable),
                new NbtList("Motion", new List<NbtDouble>
                {
                    new(MotionVelocity.X),
                    new(MotionVelocity.Y),
                    new(MotionVelocity.Z)
                }),
                new NbtBoolean("NoGravity", HasNoGravity),
                new NbtBoolean("OnGround", OnGround),
                riders,
                new NbtInt("PortalCooldown", PortalCooldown),
                new NbtList("Pos", new List<NbtDouble>
                {
                    new(Position.X),
                    new(Position.Y),
                    new(Position.Z)
                }),
                new NbtList("Rotation", new List<NbtFloat>
                {
                    new(Position.Yaw),
                    new(Position.Pitch)
                }),
                new NbtBoolean("Silent", IsSilent),
                new NbtList("Tags", NbtTagType.String),
                new NbtInt("TicksFrozen", TicksFrozenInPoweredSnow),
                new NbtIntArray("UUID", new[]
                {
                    (int) UniqueId.getMostSignificantBits(),
                    (int) UniqueId.getLeastSignificantBits()
                })
            };
                

            return entityData;
        }
    }
}