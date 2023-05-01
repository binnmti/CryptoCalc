using CryptoCalc;

namespace CryptoCalcTest;

[TestClass]
public class YenConverterTest
{
    [TestMethod]
    public void TestAdd()
    {
        var result = YenConverter.Convert("yen", "eth", 259517m);
        Assert.AreEqual(1m, result);
    }
}