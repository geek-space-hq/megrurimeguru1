using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace megrurimeguru1.WorldGen.Items.settings
{
    public class ItemCategory
    {
        public static int ID { get; set; } = -1;
        public static string Name { get; set; } = "other";
    }
    public class TerraBlocks : ItemCategory
    {
        public TerraBlocks()
        {
            Name = "TerraBlocks";
        }
    }
}

