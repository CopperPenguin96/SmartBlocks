using MinecraftTypes;

namespace SmartBlocks.Entities;

public class Fireball : Entity
{
    public override string Name => "Fireball";

    public override VarInt Type => 43;

    public override bool UseSpawnEntityOnly => true;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(1.0, 1.0, 1.0);

    public override Identifier Identifier => new("fireball");
    public override void Spawn()
    {
        throw new NotImplementedException();
    }

    public Slot Item { get; set; }
}