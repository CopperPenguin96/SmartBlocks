using MinecraftTypes;

namespace SmartBlocks.Entities;

public class ExperienceOrb : Entity
{
    public override string Name => "Experience Orb";

    public override VarInt Type => 25;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => true;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.5, 0.5, 0.5);

    public override Identifier Identifier => "experience_orb";
    public override void Spawn()
    {
        throw new NotImplementedException();
    }

    public short AwardAmount { get; set; }
}