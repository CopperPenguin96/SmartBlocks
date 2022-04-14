using Medallion;

namespace SmartBlocks.Worlds;

public class DragonFight
{
    public bool DragonKilled { get; set; } = false;

    public bool NeedsStateScanning { get; set; } = false;

    public bool PreviouslyKilled { get; set; } = false;

    private List<int>? _gateways = null;

    public List<int> Gateways
    {
        get
        {
            return _gateways ??= GenerateGateways();
        }
        set => _gateways = value;
    }

    private List<int> GenerateGateways()
    {
        List<int> selected = new();
        for (int x = 0; x <= 19; x++)
        {
            selected.Add(x);
        }
        selected.Shuffle(new Random(new Random().Next()));
        return selected;
    }
}