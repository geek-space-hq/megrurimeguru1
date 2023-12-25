using Games.CreateMap;
using XorShiftAddSharp;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod]
        public void TestMethod1()
        {
            XorShiftAddPool xorShiftAddPool = new(23);
            Games.CreateMap.GetNoise grad = new(xorShiftAddPool);
            NoisePram noisePram = new();
            noisePram.Frequency = 2;
            noisePram.Persistence = (double)1;
            noisePram.Octaves = 3;
            noisePram.Scale = 1000;
            List<NoisePram> noisePrams = new();
            noisePrams.Add(noisePram);

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    double g = grad.OctavesNoise(noisePrams, (double)i, (double)j, 0);
                    Console.WriteLine(g.ToString());
                }
            }
        }
        [TestMethod]
        public void TestMethod2()
        {
            XorShiftAddSharp.XorShiftAdd xor = new(11);
            Console.WriteLine(xor.NextDouble());
            Console.WriteLine(xor.NextDouble());
        }
        [TestMethod]
        public void CreateMapImgTest1()
        {
            XorShiftAddPool xorShiftAddPool = new(23);
            Games.CreateMap.CreateMapImg grad = new(xorShiftAddPool);
            List<NoisePram> noisePrams = new();
            noisePrams.Add(new());
            noisePrams[0].Frequency = 2;
            noisePrams[0].Persistence = 1;
            noisePrams[0].Octaves = 3;
            noisePrams[0].Scale = 100;
            noisePrams[0].Mode = 0;

            noisePrams.Add(new());
            noisePrams[1].Frequency = 0.5;
            noisePrams[1].Persistence = 20;
            noisePrams[1].Octaves = 2;
            noisePrams[1].Scale = 100;
            noisePrams[1].Mode = 1;

            noisePrams.Add(new());
            noisePrams[2].Frequency = 2;
            noisePrams[2].Persistence = 1;
            noisePrams[2].Octaves = 1;
            noisePrams[2].Scale = 500;
            noisePrams[2].Mode = 1;
            noisePrams[2].OffsetX = 256;
            noisePrams[2].OffsetY = 256;

            noisePrams.Add(new());
            noisePrams[3].Frequency = 2;
            noisePrams[3].Persistence = 1;
            noisePrams[3].Octaves= 1;
            noisePrams[3].Scale = 1000;
            noisePrams[3].Mode = 0;
            noisePrams[3].OffsetX = 1000;
            noisePrams[3].OffsetY = 1000;
            grad.createMono(noisePrams);
        }
    }
}