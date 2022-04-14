using MinecraftTypes;

namespace SmartBlocks.Entities;

public class DragonFireball : Entity
{
    public override string Name => "Dragon Fireball";

    public override VarInt Type => 16;

    public override bool UseSpawnEntityOnly => true;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(1.0, 1.0, 1.0);

    public override Identifier Identifier => "dragon_fireball";

    public override void Spawn()
    {
        throw new NotImplementedException();
    }
}