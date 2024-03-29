using CryptoCalc;

namespace CryptoCalcTest;

[TestClass]
public class CalcTest
{
    [TestMethod]
    [DataRow(new[] { "3", "+", "=", }, 6)]
    [DataRow(new[] { "1", "2", "+", "1", "2", "=", "1", "2", }, 12)]
    [DataRow(new[] { "1", "2", "3" }, 123)]
    [DataRow(new[] { "1", "2", "+" }, 12)]
    [DataRow(new[] { "1", "2", "+", "2", "1", "+" }, 33)]
    [DataRow(new[] { "1", "+", "2", "=" }, 3)]
    [DataRow(new[] { "1", "-", "2", "=" }, -1)]
    [DataRow(new[] { "2", "�~", "3", "=" }, 6)]
    [DataRow(new[] { "6", "��", "2", "=" }, 3)]
    [DataRow(new[] { "1", "2", "+", "2", "1" }, 21)]
    public void TestAdd(string[] input, double expected)
    {
        // Arrange
        var calc = new Calc();

        // Act
        foreach (var str in input)
        {
            calc.Add(str);
        }

        // Assert
        Assert.AreEqual((decimal)expected, calc.CurrentNumber);
    }
}