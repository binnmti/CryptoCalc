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
        decimal dnowPrice = (decimal)nowPrice;
        decimal dnewPrice = (decimal)newPrice;
        var result = SymbolConverter.Convert(nowSymbol, newSymbol, dnowPrice);
        Assert.AreEqual(dnewPrice, result);
    }
}