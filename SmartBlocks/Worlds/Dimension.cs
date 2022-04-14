using MinecraftTypes;

namespace SmartBlocks.Worlds;

public sealed class Dimension
{
    public static readonly Dimension Overworld = new("overworld");
    public static readonly Dimension TheNether = new("the_nether");
    public static readonly Dimension TheEnd = new("the_end");

    private readonly Identifier _type;

    private Dimension(string type)
    {
        _type = type ?? throw new ArgumentNullException(nameof(type));
    }

    public static bool operator ==(Dimension d1, string s1)
    {
        return d1._type.ToString() == s1;
    }

    public static bool operator !=(Dimension d1, string s1)
    {
        return !(d1 == s1);
    }

    public static implicit operator Dimension(string type)
    {
        return new(type);
    }

    public static implicit operator string(Dimension d1)
    {
        return d1._type.ToString();
    }

    private bool Equals(Dimension other)
    {
        return _type.ToString() == other._type.ToString();
    }

    public override bool Equals(object? obj)
    {
        return this.Equals((Dimension)obj!);
    }

    public override int GetHashCode()
    {
        return _type.GetHashCode();
    }

    public override string ToString()
    {
        return _type.ToString();
    }
}