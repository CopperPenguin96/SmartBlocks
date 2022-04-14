using MinecraftTypes;
using SmartNbt.Tags;

namespace SmartBlocks.Worlds;

public class InterestPoint : ITagProvider
{
    public const int DataVersion = 2730;

    public Position Position { get; set; }

    public int FreeTickets { get; set; }

    public InterestPointType Type { get; set; }

    public Identifier Identifier => new Identifier(Type.ToString().ToLower());

    public override string ToString() => Identifier.ToString();

    public NbtTag Tag
    {
        get
        {
            return new NbtCompound()
            {
                new NbtIntArray("pos", new[]
                {
                    Position.X, Position.Y, Position.Z
                }),
                new NbtInt("free_tickets", FreeTickets),
                new NbtString("type", ToString())
            };
        }
    }
}
    
public enum InterestPointType : byte
{
    UnEmployed = 0x00,
    Armorer = 0x01,
    Butcher = 0x02,
    Cartographer = 0x03,
    Cleric = 0x04,
    Famrer = 0x05,
    Fisherman = 0x06,
    Fletcher = 0x07,
    Leatherworker = 0x08,
    Librarian = 0x09,
    Mason = 0x0A,
    Nitwith = 0x0B,
    Shepherd = 0x0C,
    Toolsmith = 0x0D,
    Weaponsmith = 0x0E,
    Home = 0x0F,
    Meeting = 0x10,
    NetherPortal = 0x11,
    BeeHive = 0x012,
    BeeNest = 0x13
}