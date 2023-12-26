using XorShiftAddSharp;

namespace Games
{
    namespace Test
    {
        public class Test
        {
            //乱数生成器を管理するためのプール
            //初期値をぶち込むと後は2^64ごとにHOPするので並列時の状態管理はConsumer側で気にする必要が無い
            private static readonly XorShiftAddPool Pool = new(42);

            static void Main(string[] args)
            {
                //並列実行するためのParallelFor
                Parallel.For(0, 10, ParallelWork);
            }

            private static void ParallelWork(int number)
            {
                //ここでプールから乱数生成器を借りてくる
                var rnd = Pool.Get();

                try
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine($"{number}:{i}:{rnd.NextInt64()}");
                    }
                }
                finally
                {
                    //使い終わったら、返却する
                    Pool.Return(rnd);
                }
            }
        }
    }
}