using CryptoCalc;

namespace CryptoCalcTest;

[TestClass]
public class SymbolConverterTest
{
    //TODO:問題1.このテストの値は動的に変動してしまう。これは解決不可
    //TODO:問題2.誤差が出る。これは解決出来る？
    //[TestMethod]
    //[DataRow("yen", "eth", 259517, 1)]
    //[DataRow("yen", "matic", 136, 1)]
    //[DataRow("eth", "yen", 0.01, 2595.17)]
    //[DataRow("eth", "matic", 0.01, 19.0821323529412)]
    //[DataRow("matic", "yen", 100, 13600)]
    //[DataRow("matic", "eth", 100, 0.0524050447562202)]
    //public void TestAdd(string nowSymbol, string newSymbol, double nowPrice, double newPrice)
    //{
    //    var nowPriceD = (decimal)nowPrice;
    //    var newPriceD = (decimal)newPrice;

    //    var result = SymbolConverter.Convert(nowSymbol, newSymbol, nowPriceD);
    //    Assert.AreEqual(newPriceD, result);
    //}
}