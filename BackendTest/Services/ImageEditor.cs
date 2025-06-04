using BackendTest.Models;
using BackendTest.Plugins;

namespace BackendTest.Services
{
    /// <summary>
    /// Responsible for executing image transformations.
    /// </summary>
    public class ImageEditor
    {
        /// <summary>
        /// Simulates image resizing.
        /// </summary>
        private Stream ResizeImage(Stream image, int size)
        {
            Console.WriteLine($"[Resize] Image resized to {size}px");
            return image;
        }

        /// <summary>
        /// Simulates applying blur radius.
        /// </summary>
        private Stream ApplyRadius(Stream image, int radius)
        {
            Console.WriteLine($"[Radius] Blur radius applied: {radius}px");
            return image;
        }

        /// <summary>
        /// Main method for processing an image using provided settings.
        /// </summary>
        /// <param name="settings">Settings object with image, effects and parameters</param>
        /// <returns>Processed image stream</returns>
        public static Task<Stream> ProcessImage(Settings settings)
        {
            var editor = new ImageEditor();
            Stream processedImage = settings.Image;

            if (settings.Size > 0)
                processedImage = editor.ResizeImage(processedImage, settings.Size);

            if (settings.Radius > 0)
                processedImage = editor.ApplyRadius(processedImage, settings.Radius);

            foreach (var effect in settings.Effects)
            {
                var plugin = PluginFactory.CreatePlugin(effect);
                processedImage = plugin.Apply(processedImage);
            }

            return Task.FromResult(processedImage);
        }
    }
}
