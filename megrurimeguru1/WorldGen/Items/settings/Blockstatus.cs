using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SixLabors.ImageSharp.PixelFormats;

namespace megrurimeguru1.WorldGen.Items.settings
{
    public class BlockPram
    {
        /// <summary>
        /// IDは自動で振るかも
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// アイテムの名前 未設定だとvoid
        /// </summary>
        public string Name { get; set; } = "void";

        /// <summary>
        /// アイテムの説明 未設定だとvoid
        /// </summary>
        public string Description { get; set; } = "void";

        /// <summary>
        /// テクスチャの相対フォルダパス
        /// </summary>
        public FileInfo Texture { get; set; }

        /// <summary>
        /// テクスチャ未設定時に表示するRGBコード
        /// </summary>
        public Rgba32 Color { get; set; }

        /// <summary>
        /// アイテムのカテゴリー
        /// </summary>
        public ItemCategory Category { get; set; }
    }
}
