using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SixLabors.ImageSharp.PixelFormats;

namespace megrurimeguru1.Item
{
    public class BlockPram
    {
        public int ID {  get; set; }=-1;
        public string Name { get; set; } = "void";
        public string Description { get; set; } = "void";
        public FileInfo? Texture { get; set; }
        public Rgba32 Callor { get; set; }
        public ItemCategory? Category { get; set; }
    }
}
