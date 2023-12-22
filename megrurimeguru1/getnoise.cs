using Microsoft.Extensions.ObjectPool;
using XorShiftAddSharp;
namespace Games
{
    namespace CreateMap
    {
        public class GetNoise
        {
            public uint Seed;
            public GetNoise(uint seed)
            {
                Seed = seed;
            }
            /// <summary>
            /// 乱数生成器を管理するためのプール
            /// </summary>
            private static readonly XorShiftAddPool Pool = new XorShiftAddPool(111);

            /// <summary>
            /// 座標からパーリンノイズを生成する
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <param name="z"></param>
            /// <returns>0~1の範囲のノイズ</returns>
            public double CreateNoise(double x, double y, double z = 0)
            {
                //ここでプールから乱数生成器を借りてくる
                var rnd = Pool.Get();

                double xf = x - Math.Floor(x);
                double yf = y - Math.Floor(y);
                double zf = z - Math.Floor(z);

                int xa = (int)Math.Floor(x);
                int ya = (int)Math.Floor(y);
                int za = (int)Math.Floor(z);

                //取り出した小数部を滑らかにする
                double u = smootherStep(xf);
                double v = smootherStep(yf);
                double w = smootherStep(zf);

                //255以上にならないようにする
                int p000 = (int)GetIndex(rnd.NextDouble());
                int p010 = (int)GetIndex(rnd.NextDouble());
                int p001 = (int)GetIndex(rnd.NextDouble());
                int p011 = (int)GetIndex(rnd.NextDouble());
                int p100 = (int)GetIndex(rnd.NextDouble());
                int p110 = (int)GetIndex(rnd.NextDouble());
                int p101 = (int)GetIndex(rnd.NextDouble());
                int p111 = (int)GetIndex(rnd.NextDouble());

                double g000 = GetGrad(p000, xf, yf, zf);
                double g100 = GetGrad(p100, xf - 1, yf, zf);
                double g010 = GetGrad(p010, xf, yf - 1, zf);
                double g001 = GetGrad(p001, xf, yf, zf - 1);
                double g110 = GetGrad(p110, xf - 1, yf - 1, zf);
                double g011 = GetGrad(p011, xf, yf - 1, zf - 1);
                double g101 = GetGrad(p101, xf - 1, yf, zf - 1);
                double g111 = GetGrad(p111, xf - 1, yf - 1, zf - 1);

                double x0 = lerp(g000, g100, u);
                double x1 = lerp(g010, g110, u);
                double x2 = lerp(g001, g101, u);
                double x3 = lerp(g011, g111, u);
                double y0 = lerp(x0, x1, v);
                double y1 = lerp(x2, x3, v);
                double z0 = lerp(y0, y1, w);

                Pool.Return(rnd);
                //return z0;
                return (z0 + 1) / 2;
            }
            /// <summary>
            /// 格子点の固有ベクトルを求める
            /// </summary>
            /// <param name="index">0~255までのどれか</param>
            /// <param name="x">x座標の小数部</param>
            /// <param name="y">y座標の小数部</param>
            /// <param name="z">z座標の小数部 3Dでない場合は0</param>
            /// <returns></returns>
            public double GetGrad(int index, double x, double y, double z = 0)
            {
                //格子点8つ分の固有ベクトルを求める
                //indexから最初の4ビットを取り出す
                int h = index & 15;

                //indexの最上位ビット(MSB)が0であれば u=xとする そうでなければy
                double u = h < 8 ? x : y;

                double v;

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
            /// <param name="seed">0~1の値</param>
            /// <returns></returns>
            public double GetIndex(double rnd)
            {
                double index = Math.Round(rnd * 255);
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

            public double lerp(double a, double b, double t)
            {
                return a + (b - a) * t;
            }
        }
    }

}