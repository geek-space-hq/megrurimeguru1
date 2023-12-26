using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace megrurimeguru1.Item.Blocks
{
    public class Water : BlockPram
    {
        public Water()
        {
            Name = "water";
            Callor = new(200, 200,120);
            Category = ItemCategorys.TerraBlocks;
;        }
    }
}
