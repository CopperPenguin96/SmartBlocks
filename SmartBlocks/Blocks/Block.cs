using MinecraftTypes;

namespace SmartBlocks.Blocks;

public class Block
{
    public string Name { get; set; }

    public Identifier ItemId { get; set; }

    public bool IsStackable { get; set; }

    public short MaxStackSize { get; set; }

    public double Hardness { get; set; }

    public bool IsDiggable { get; set; }

    public short MinStateId { get; set; }

    public short MaxStateId { get; set; }

    public uint Id { get; set; }

    public uint Type { get; set; }

        
    public Block()
    {
        // For serialization
    }

    public Block(uint id = 0, uint type = 0)
    {
        Id = id;
        Type = type;
    }

    public Block(Identifier id)
    {
        ItemId = id;
    }
}