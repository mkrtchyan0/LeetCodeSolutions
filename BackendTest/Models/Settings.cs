namespace BackendTest.Models
{
    /// <summary>
    /// Enum representing available image effects.
    /// </summary>
    public enum Effects
    {
        BlackWhite,
        Effect2,
        Effect3
    }
    /// <summary>
    /// Contains settings for processing a single image.
    /// </summary>
    public class Settings
    {
        private int size;
        private int radius;

        /// <summary>
        /// Gets or sets the image stream to process.
        /// </summary>
        public Stream Image { get; set; }

        /// <summary>
        /// List of effects to apply to the image.
        /// </summary>
        public List<Effects> Effects { get; set; } = new();

        /// <summary>
        /// Target size in pixels (must be 1–100).
        /// </summary>
        public int Size
        {
            get => size;
            set
            {
                if (value > 0 && value <= 100) size = value;
                else throw new ArgumentOutOfRangeException(nameof(Size));
            }
        }

        /// <summary>
        /// Radius for blur effect (must be 1–2048).
        /// </summary>
        public int Radius
        {
            get => radius;
            set
            {
                if (value > 0 && value <= 2048) radius = value;
                else throw new ArgumentOutOfRangeException(nameof(Radius));
            }
        }

        /// <summary>
        /// Initializes settings with image only.
        /// </summary>
        public Settings(Stream image) : this(image, new List<Effects>()) { }

        /// <summary>
        /// Initializes settings with image and effects.
        /// </summary>
        public Settings(Stream image, List<Effects> effects) : this(image, effects, 0) { }

        /// <summary>
        /// Initializes settings with image, effects and size.
        /// </summary>
        public Settings(Stream image, List<Effects> effects, int size) : this(image, effects, size, 0) { }

        /// <summary>
        /// Full constructor with all parameters.
        /// </summary>
        public Settings(Stream image, List<Effects> effects, int size, int radius)
        {
            Image = image;
            Effects = effects;
            Size = size;
            Radius = radius;
        }
    }
}
