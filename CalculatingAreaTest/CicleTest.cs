using CalculatingArea;

namespace CalculatingAreaTest;

[TestClass]
public class CicleTest
{
    [TestMethod]
    public void PositivTestMethod()
    {
        Calculating Cal = new Calculating(2);

        var result = Cal.GetArea();

        Assert.AreEqual(12.56, result);
    }
}
