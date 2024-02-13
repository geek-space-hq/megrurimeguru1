using megrurimeguru1.Item.Blocks;
using megrurimeguru1.WorldGen.Biomes.settings;
using megrurimeguru1.WorldGen.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace megrurimeguru1.WorldGen.Biomes
{
    public class OverWorlds:BiomePram
    {
        public Plane()
        {
            Name = "Plane";
            Description = "草wwww";
            Color = new Rgba32(150, 190, 100);
            BiomeCategory = OverWorld;
            MinZ = 64;
            MaxZ = 255;
            Blocks = Glass;
            UnderWaterBlocks = Sand;
            NearWaterBlockCount = 0;
            GenerationFrequency = 60;
        }
        public Beach()
        {
            Name = "Beach";
            Description = "砂浜";
            Color = Sand.Color;
            BiomeCategory = OverWorld;
            MinZ = 60;
            MaxZ = 69;
            Blocks = Sand;
            UnderWaterBlocks = Sand;
            GenerationFrequency = 30;
        }

    }
}
