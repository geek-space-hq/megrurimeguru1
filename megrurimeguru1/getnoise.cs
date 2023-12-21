﻿
namespace Games
{
    namespace CreateMap
    {
        public class GetNoise
        {
            /// <summary>
            /// 格子点の固有ベクトルを求める
            /// </summary>
            /// <param name="index">0~255までのどれか</param>
            /// <param name="x">x座標の小数部</param>
            /// <param name="y">y座標の小数部</param>
            /// <param name="z">z座標の小数部 3Dでない場合は0</param>
            /// <returns></returns>
            public float GetGrad(int index, float x, float y, float z = 0)
            {
                //格子点8つ分の固有ベクトルを求める
                //indexから最初の4ビットを取り出す
                int h = index & 15;

                //indexの最上位ビット(MSB)が0であれば u=xとする そうでなければy
                float u = h < 8 ? x : y;

                float v;

                // 第1および第2ビットが0の場合、v = yとする
                if (h < 4)
                {
                    v = y;
                }

                //最初と2番目の上位ビットが1の場合、v = xとする
                else if (h == 12 || h == 14)
                {
                    v = x;
                }

                // 第1および第2上位ビットが等しくない場合（0/1、1/0）、v = zとする
                else
                {
                    v = z;
                }
                // 最後の2ビットを使って、uとvが正か負かを判断する そしてそれらの加算を返す
                return ((h & 1) == 0 ? u : -u) + ((h & 2) == 0 ? v : -v);
            }

            /// <summary>
            /// 0~1の乱数を0~255に変換する
            /// </summary>
            /// <param name="seed">シード値</param>
            /// <returns></returns>
            public double GetIndex(uint seed)
            {
                XorShiftAddSharp.XorShiftAdd xorShift = new(seed);
                double index=Math.Round(xorShift.NextDouble()*255);
                return index;

            }

            /// <summary>
            /// 補完関数 滑らかにするっぽい
            /// </summary>
            /// <param name="x">小数部</param>
            /// <returns></returns>
            public double smootherStep(double x)
            {
                return x * x * x * (x * (x * 6 - 15) + 10);
            }

            public double lerp(double a,double b,double t)
            {
                return (a + b) * t;
            }
        }
    }

}