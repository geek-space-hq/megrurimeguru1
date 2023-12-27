using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace megrurimeguru1.Item.Blocks
{
    public class Sand : Block
    {
        public Sand()
        {
            BlockPram sand = new BlockPram();
            sand.Name = "sand";
            sand.Color =new(100,100,125);
            sand.Description = "砂";
        }
    }
}
