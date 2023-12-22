using Games.CreateMap;

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
            Games.CreateMap.GetNoise grad = new(0);

            for (double i = 0; i < 1000; i++)
            {
                for (double j = 0; j < 1000; j++)
                {
                    double g = grad.CreateNoise(i / 1000, j/1000, 0);
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
    }
}