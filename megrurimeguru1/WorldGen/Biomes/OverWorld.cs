using megrurimeguru1.WorldGen.Biomes.settings;
using megrurimeguru1.WorldGen.Items;
using SixLabors.ImageSharp.PixelFormats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace megrurimeguru1.WorldGen.Biomes
{
    public class OverWorlds {
        public BiomePram PlaneBiome;

        public OverWorlds(){
            PlaneBiome.Name = "Plane";
            PlaneBiome.Description = "草wwww";
            PlaneBiome.Color = new Rgba32(150, 190, 100);
            PlaneBiome.Category = OverWorld;
            PlaneBiome.MinZ = 64;
            PlaneBiome.MaxZ = 255;
            PlaneBiome.Blocks = Glass;
            PlaneBiome.UnderWaterBlocks = Sand;
            PlaneBiome.NearWaterBlockCount = 0;
            PlaneBiome.GenerationFrequency = 60;

        }
        /*
        PlaneBiome. = "Plane";
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
        public void Beach()
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
        }*/

    }
}
