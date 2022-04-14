using MinecraftTypes;

namespace SmartBlocks.Entities;

public class ThrownPotion : Entity
{
    public override string Name => "Thrown Potion";

    public override VarInt Type => 92;

    public override bool UseSpawnEntityOnly => true;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.25, 0.25, 0.25);

    public override Identifier Identifier => new("potion");
    public override void Spawn()
    {
        throw new NotImplementedException();
    }

    public Slot Item { get; set; }
}