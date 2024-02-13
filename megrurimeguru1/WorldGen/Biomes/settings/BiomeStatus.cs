using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SixLabors.ImageSharp.PixelFormats;
using megrurimeguru1.WorldGen.Items.settings;

namespace megrurimeguru1.WorldGen.Biomes.settings
{
    public class BiomePram
    {
        /// <summary>
        /// IDは自動で振るかも
        /// </summary>
        public int ID { get; set; }

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
        public BiomeCategory Category { get; set; }

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
        public Rgba32 WaterColor { get; set; }

        /// <summary>
        /// 地表で生成するブロック
        /// </summary>
        public Block Blocks { get; set; }

        /// <summary>
        /// 水中で生成するブロック
        /// </summary>
        public Block UnderWaterBlocks { get; set; }

        /// <summary>
        /// 水と隣合う場合に設定するブロック
        /// </summary>
        public Block NearWaterBlocks { get; set; }

        /// <summary>
        /// 水に隣合う場合に設定するブロックの巾
        /// </summary>
        public int NearWaterBlockCount { get; set; } = 2;

        /// <summary>
        /// 別のバイオームの中に生成するかどうか
        /// </summary>
        public bool GenerateInOtherBiomes { get; set; }

        /// <summary>
        /// 出現頻度
        /// 0~100
        /// 0=出現しない
        /// 100=必ずそのバイオームになる
        /// 100のバイオームが重なった場合、出現率は50%
        /// </summary>
        public int GenerationFrequency { get; set; }

        /// <summary>
        /// 標高によって色を変える場合一番低い場所の色を指定
        /// </summary>
        public Rgba32 DeepColor {  get; set; }

        /// <summary>
        /// 標高によって色を変える際の変更分割数
        /// 0=分割なし 滑らかに変化
        /// </summary>
        public int Segments { get; set; } = 0;
    }

    /// <summary>
    /// int 0~255 高さ設定
    /// </summary>
    public sealed class Hight
    {
        private int Value { get; }
        public Hight(int value)
        {
            if (value <= 0 || value >= 256 || value == null)
            {
                throw new ArgumentOutOfRangeException("設定値が256以上もしくはnullです");
            }
            Value = value;
        }
        public static implicit operator int(Hight value) => value.Value;
        public static implicit operator Hight(int value) => new Hight(value);
    }
}
