using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp;
using XorShiftAddSharp;

namespace Games.megrurimeguru1.CreateWorld
{
    /// <summary>
    /// 確認画像生成用クラス
    /// </summary>
    public class CreateMapImg
    {
        private XorShiftAddPool XorRand;

        /// <summary>
        /// ノイズ分布用確認用のマップを生成する
        /// 乱数器を丸ごと渡す
        /// </summary>
        /// <param name="xorRand">xorShift乱数器</param>
        public CreateMapImg(XorShiftAddPool xorRand)
        {
            XorRand = xorRand;
        }

        /// <summary>
        /// 4色で塗分けた確認用画像生成
        /// </summary>
        /// <param name="noisePram">noisePramの数だけ処理をする</param>
        /// <param name="ImageHeight">画像縦</param>
        /// <param name="ImageWidth">画像横</param>
        /// <param name="StarX">生成開始座標x</param>
        /// <param name="StartY">生成開始座標y</param>
        /// <param name="SavePath">画像保存パス</param>
        public void CreateImg(List<NoisePram> noisePram, int ImageHeight = 500, int ImageWidth = 500, int StarX = 0, int StartY = 0, String SavePath = "..\\test.png")
        {
            GetNoise getNoise = new GetNoise(XorRand);
            //空の画像を生成
            var img = new Image<Rgba32>(ImageHeight, ImageWidth);
            List<List<double>> CheckImg = new();
            double Maxblue = 0;
            double Minblue = 2;
            for (int i = 0; i < img.Height; i++)
            {
                List<double> data = new List<double>();
                for (int j = 0; j < img.Width; j++)
                {

                    float blue = (float)getNoise.OctavesNoise(noisePram, (double)i, (double)j);
                    data.Add(blue);
                    if (Maxblue < blue) Maxblue = blue;
                    if (Minblue > blue) Minblue = blue;
                }
                CheckImg.Add(data);
            }
            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    if (CheckImg[i][j] < ((Maxblue - Minblue) / 4 * 1) + Minblue)
                    {
                        img[i, j] = new Rgba32(30, 50, 125);
                    }
                    else if (CheckImg[i][j] < ((Maxblue - Minblue) / 4 * 2) + Minblue)
                        img[i, j] = new Rgba32(30, 130, 220);
                    else if (CheckImg[i][j] < ((Maxblue - Minblue) / 4 * 3) + Minblue)
                        img[i, j] = new Rgba32(200, 200, 120);
                    else
                        img[i, j] = new Rgba32(150, 190, 100);
                }
                //img[i, j] = new Rgba32(0, 0, blue);

            }
            img.Save(SavePath);
        }


    }
}
