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
          Games.CreateMap.GetNoise = new();

            for (int i = 0; i < 256; i++)
            {
                float g=grad.GetGrad(i, 1, 1);
                Console.WriteLine(g.ToString());
            }
        }
    }
}