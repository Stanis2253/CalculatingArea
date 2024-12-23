using CalculatingArea;

namespace CalculatingAreaTest;

[TestClass]
public class TriagngelTest
{
    [TestMethod]
    public void PositivTestMethod()
    {
        Calculating Cal = new Calculating(2,3,4);

        var result = Cal.GetArea();

        Assert.AreEqual(2.9047375096555625, result);
    }
}
