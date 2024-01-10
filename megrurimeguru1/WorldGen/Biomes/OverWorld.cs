using SixLabors.ImageSharp.PixelFormats;
using megrurimeguru1.WorldGen.Biomes.settings;
using megrurimeguru1.WorldGen.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace megrurimeguru1.WorldGen.Biomes
{
    public class Plane:BiomePram
    {
        public Plane()
        {
            Name = "Plane";
            Description = "草wwww";
            Color = new Rgba32(150, 190, 100);
            Category = new OverWorld();
            MinZ = 20;
            MaxZ = 255;
            Blocks = new Glass();


        }
    }
}
