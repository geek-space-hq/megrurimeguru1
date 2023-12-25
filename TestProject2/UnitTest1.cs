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
            NoisePram noisePram = new();
            noisePram.Frequency = 2;
            noisePram.Persistence = 1;
            noisePram.Octaves = 3;
            noisePram.Scale = 100;
            List<NoisePram> noisePrams = new();
            noisePrams.Add(noisePram);
            grad.createMono(noisePrams);
        }
    }
}