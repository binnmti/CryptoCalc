using CryptoCalc;

namespace CryptoCalcTest;

[TestClass]
public class CoinMarketCapApiUtilityTest
{
    [TestMethod]
    public void TestAdd()
    {
        // Arrange
        CoinMarketCapApiUtility.MakeAPICall();

        // Act
        //foreach (var str in input)
        //{
        //    calc.Add(str);
        //}

        // Assert
        //Assert.AreEqual((decimal)expected, calc.CurrentNumber);
    }
}