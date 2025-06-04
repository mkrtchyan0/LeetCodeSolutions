namespace BackendTest.Plugins
{
    /// <summary>
    /// Interface that all image plugins must implement.
    /// </summary>
    public interface IImagePlugin
    {
        /// <summary>
        /// Applies the effect to the given image stream.
        /// </summary>
        Stream Apply(Stream image);
    }
}
