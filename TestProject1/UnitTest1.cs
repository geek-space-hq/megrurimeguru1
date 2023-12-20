using Xunit.Abstractions;
using Games.CreateMap;

public class XUnitTestClass
{
    private readonly ITestOutputHelper _Output;
    public XUnitTestClass(ITestOutputHelper output)
    {
        _Output = output;
    }
    [Fact]
    public void Test1()
    {
        for (int i = 0; i < 1000; i++)
        {
            Games.CreateMap.Grad grad = new();
            float a = grad.GetGrad(i, 1, 1);
            _Output.WriteLine(a.ToString());
        }
    }
}