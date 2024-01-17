using megrurimeguru1.WorldGen.Items.settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace megrurimeguru1.WorldGen.Items
{
    /// <summary>
    /// 草
    /// </summary>
    public class Glass : BlockPram
    {
        public Glass()
        {
            Name = "Glass";
            Color = new(150, 190, 100);
            Description = "草";
            Category = new TerraBlocks();

        }
    }

    public class Sand : BlockPram
    {
        public Sand()
        {
            Name = "sand";
            Color = new(100, 100, 125);
            Description = "砂";
            Category= new TerraBlocks();

        }
    }
    public class Water : BlockPram
    {
        public Water()
        {
            Name = "water";
            Color = new(200, 200, 120);
            Category = new TerraBlocks();
        }
    }
}
