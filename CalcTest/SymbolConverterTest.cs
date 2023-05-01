using CryptoCalc;

namespace CryptoCalcTest;

[TestClass]
public class SymbolConverterTest
{
    [TestMethod]
    [DataRow("yen", "eth", 259517, 1)]
    [DataRow("yen", "matic", 136, 1)]
    public void TestAdd(string nowSymbol, string newSymbol, double nowPrice, double newPrice)
    {
        var nowPriceD = (decimal)nowPrice;
        var newPriceD = (decimal)newPrice;

        var result = SymbolConverter.Convert(nowSymbol, newSymbol, nowPriceD);
        Assert.AreEqual(newPriceD, result);
    }
}