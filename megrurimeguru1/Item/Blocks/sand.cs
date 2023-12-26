using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace megrurimeguru1.Item.Blocks
{
    public class Sand : BlockPram
    {
        public Sand()
        {
            Name = "sand";
            Callor = new(200, 200, 120);
            Category = ItemCategorys.TerraBlocks;

        }
    }
}
