using CryptoCalc;

namespace CalcTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calc = new Calc();
            calc.Add("1");
            calc.Add("2");
            calc.Add("3");
            Assert.AreEqual(calc.CurrentNumber, 123);
        }
    }
}