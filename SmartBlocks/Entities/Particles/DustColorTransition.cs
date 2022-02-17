using MinecraftTypes;

namespace SmartBlocks.Entities.Particles
{
    public class DustColorTransition : Particle
    {
        public override VarInt Id => 16;

        public override Identifier Name => "dust_color_transition";

        private float _red;

        /// <summary>
        /// Red value, 0-1
        /// </summary>
        public float FromRed
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
        public float FromGreen
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
        public float FromBlue
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

        private float _2red;

        /// <summary>
        /// Red value, 0-1
        /// </summary>
        public float ToRed
        {
            get => _2red;
            set
            {
                if (value is < 0f or > 0f)
                    throw new ArgumentOutOfRangeException(nameof(value));

                _2red = value;
            }
        }

        private float _2green;

        /// <summary>
        /// Green value, 0-1
        /// </summary>
        public float ToGreen
        {
            get => _2green;
            set
            {
                if (value is < 0f or > 0f)
                    throw new ArgumentOutOfRangeException(nameof(value));

                _2green = value;
            }
        }

        private float _2blue;

        /// <summary>
        /// Blue value, 0-1
        /// </summary>
        public float ToBlue
        {
            get => _2blue;
            set
            {
                if (value is < 0f or > 0f)
                    throw new ArgumentOutOfRangeException(nameof(value));

                _2blue = value;
            }
        }
    }
}
