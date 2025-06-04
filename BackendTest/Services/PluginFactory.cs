using BackendTest.Models;
using BackendTest.Plugins;

namespace BackendTest.Services
{
    /// <summary>
    /// Factory class for converting Effects enum into plugin instances.
    /// </summary>
    public static class PluginFactory
    {
        /// <summary>
        /// Creates an instance of plugin based on the effect.
        /// </summary>
        public static IImagePlugin CreatePlugin(Effects effect)
        {
            return effect switch
            {
                Effects.BlackWhite => new BlackWhitePlugin(),
                Effects.Effect2 => new Effect2Plugin(),
                Effects.Effect3 => new Effect3Plugin(),
                _ => throw new NotSupportedException($"Effect '{effect}' is not supported.")
            };
        }
    }
}
