using CryptoCalc;

namespace CryptoCalcTest;

[TestClass]
public class SymbolConverterTest
{
    [TestMethod]
    [DataRow("yen", "eth", 259517)]
    public void TestAdd(string nowSymbol, string newSymbol, double price)
    {
        decimal dprice = (decimal)price;
        var result = SymbolConverter.Convert(nowSymbol, newSymbol, dprice);
        Assert.AreEqual(1m, result);
    }
}