using MinecraftTypes;

namespace SmartBlocks.Entities.Particles;

public class Dust : Particle
{
    public override VarInt Id => 15;

    public override Identifier Name => "dust";

    private float _red;
        
    /// <summary>
    /// Red value, 0-1
    /// </summary>
    public float Red
    {
        get => _red;
        set
        {
            if (value is < 0f or > 0f)
                throw new ArgumentOutOfRangeException(nameof(value));

            _red = value;
        }
    }

    private float _green;

    /// <summary>
    /// Green value, 0-1
    /// </summary>
    public float Green
    {
        get => _green;
        set
        {
            if (value is < 0f or > 0f)
                throw new ArgumentOutOfRangeException(nameof(value));

            _green = value;
        }
    }

    private float _blue;

    /// <summary>
    /// Blue value, 0-1
    /// </summary>
    public float Blue
    {
        get => _blue;
        set
        {
            if (value is < 0f or > 0f)
                throw new ArgumentOutOfRangeException(nameof(value));

            _blue = value;
        }
    }

    /// <summary>
    /// The scale, will be clamped between 0.01 and 4.
    /// </summary>
    private float Scale { get; set; }
}