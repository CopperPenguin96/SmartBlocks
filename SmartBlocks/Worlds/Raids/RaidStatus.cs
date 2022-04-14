namespace SmartBlocks.Worlds.Raids;

// ongoing victory loss stopped
public sealed class RaidStatus
{
    public static readonly RaidStatus Ongoing = "ongoing";
    public static readonly RaidStatus Victory = "victory";
    public static readonly RaidStatus Loss = "loss";
    public static readonly RaidStatus Stopped = "stopped";

    private readonly string _status;

    private RaidStatus(string status)
    {
        _status = status;
    }

    public static implicit operator RaidStatus(string item)
    {
        return new(item);
    }

    public static bool operator ==(RaidStatus s1, RaidStatus s2)
    {
        return s1._status == s2._status;
    }

    public static bool operator !=(RaidStatus s1, RaidStatus s2)
    {
        return !(s1 == s2);
    }
    private bool Equals(RaidStatus other)
    {
        return _status == other._status;
    }

    public override bool Equals(object? obj)
    {
        return ReferenceEquals(this, obj) || obj is RaidStatus other && Equals(other);
    }

    public override int GetHashCode()
    {
        return _status.GetHashCode();
    }

    public override string ToString()
    {
        return _status;
    }
}