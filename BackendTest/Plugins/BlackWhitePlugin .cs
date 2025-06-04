using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendTest.Plugins
{
    /// <summary>
    /// Simulated plugin that converts the image to black and white.
    /// </summary>
    public class BlackWhitePlugin : IImagePlugin
    {
        public Stream Apply(Stream image)
        {
            Console.WriteLine("[BlackWhitePlugin] Applied black & white effect");
            return image;
        }
    }
}
