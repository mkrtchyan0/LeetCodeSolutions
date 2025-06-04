using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendTest.Plugins
{
    public class Effect2Plugin : IImagePlugin
    {
        public Stream Apply(Stream image)
        {
            Console.WriteLine("[Plugin] Effect2 applied");
            return image;
        }
    }
}
