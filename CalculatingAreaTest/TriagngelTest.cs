using CalculatingArea;

namespace CalculatingAreaTest;

[TestClass]
public class TriagngelTest
{
    [TestMethod]
    public void PositivTestMethod()
    {
        Calculating Cal = new Calculating(2,3,4);

        var result = Math.Round( Cal.GetArea(), 1);

        Assert.AreEqual(2.9, result);
    }
}
