using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SixLabors.ImageSharp.PixelFormats;
using megrurimeguru1.Item.Blocks;

namespace megrurimeguru1.Item.Biomes
{
    public class BiomePram
    {
        /// <summary>
        /// IDは自動で振るかも
        /// </summary>
        public int? ID { get; set; }

        /// <summary>
        /// バイオームの名前
        /// </summary>
        public string Name { get; set; } = "void";

        /// <summary>
        /// バイオームの説明
        /// </summary>
        public string Description { get; set; } = "void";

        /// <summary>
        /// 確認画像用のRGBコード
        /// </summary>
        public Rgba32 Color { get; set; } = new Rgba32(0, 0, 0);

        /// <summary>
        /// バイオームのカテゴリー
        /// </summary>
        public BiomeCategory? Category { get; set; }

        /// <summary>
        /// 生成最低高度 0~256
        /// </summary>
        public Hight MinZ { get; set; } = 0;

        /// <summary>
        /// 生成最高高度 0~256
        /// </summary>
        public Hight MaxZ { get; set; } = 0;

        /// <summary>
        /// 水の色
        /// </summary>
        public Rgba32? WaterColor { get; set; }

        /// <summary>
        /// 地表で生成するブロック
        /// </summary>
        public Block blocks { get; set; }

        /// <summary>
        /// 水中で生成するブロック
        /// </summary>
        public Block? UnderWaterBlocks { get; set; }

        /// <summary>
        /// 水と隣合う場合に設定するブロック
        /// </summary>
        public Block? NearWaterBlocks { get; set; }

        /// <summary>
        /// 別のバイオームの中に生成するかどうか
        /// </summary>
        public bool GenerateInOtherBiomes { get; set; }

        /// <summary>
        /// 出現頻度
        /// </summary>
        public int GenerationFrequency { get; set; }
    }

    public class BiomeCategory
    {
        public string Name { get; set; } = "other";
        public string Description { get; set; } = "other";
        public int ID { get; set; }
    }
    public class BiomeGenerateSetting
    {
        
    }
    /// <summary>
    /// int 0~255 高さ設定
    /// </summary>
    public sealed class Hight
    {
        private int? Value { get; }
        public Hight(int? value)
        {
            if (value <= 0 || value >= 256 || value == null)
            {
                throw new ArgumentOutOfRangeException("設定値が256以上もしくはnullです");
            }
            Value = value;
        }
        public static implicit operator int?(Hight value) => value.Value;
        public static implicit operator Hight(int value) => new Hight(value);
    }
}
