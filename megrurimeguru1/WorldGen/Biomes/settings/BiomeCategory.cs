using Games.GetNoise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace megrurimeguru1.WorldGen.Biomes.settings
{
    public class BiomeCategory
    {
        public string Name { get; set; } = "other";
        public string Description { get; set; } = "other";
        public int ID { get; set; }
    }
    public class OverWorld : BiomeCategory
    {
        public OverWorld()
        {
            Name = "OverWorld";
            Description = "通常世界";
        }
    }
}
