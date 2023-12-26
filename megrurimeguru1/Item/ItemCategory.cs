using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace megrurimeguru1.Item
{
    public class ItemCategory
    {
        public int ID { get; set; } = -1;
        public string Name { get; set; } = "other";
    }
    public record ItemCategorys
    {
        public static ItemCategory TerraBlocks { get; set; } = new ItemCategory();
    }
}
