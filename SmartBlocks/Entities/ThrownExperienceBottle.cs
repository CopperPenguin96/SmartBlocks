using MinecraftTypes;

namespace SmartBlocks.Entities;

public class ThrownExperienceBottle : Entity
{
    public override string Name => "Thrown Experience Bottle";

    public override VarInt Type => 91;

    public override bool UseSpawnEntityOnly => true;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.25, 0.25, 0.25);

    public override Identifier Identifier => new("experience_bottle");
    public override void Spawn()
    {
        throw new NotImplementedException();
    }

    public Slot Item { get; set; }
}