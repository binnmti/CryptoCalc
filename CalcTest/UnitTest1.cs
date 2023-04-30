using CryptoCalc;

namespace CalcTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void 数字だけを追加()
        {
            var calc = new Calc();
            calc.Add("1");
            calc.Add("2");
            calc.Add("3");
            Assert.AreEqual(calc.CurrentNumber, 123);
        }

        [TestMethod]
        public void 計算を追加()
        {
            var calc = new Calc();
            calc.Add("1");
            calc.Add("2");
            calc.Add("+");
            calc.Add("2");
            calc.Add("1");
            calc.Add("=");
            Assert.AreEqual(calc.CurrentNumber, 33);
        }

        [TestMethod]
        public void 記号止め()
        {
            var calc = new Calc();
            calc.Add("1");
            calc.Add("2");
            calc.Add("+");
            Assert.AreEqual(calc.CurrentNumber, 12);
        }

        [TestMethod]
        public void 記号止め2()
        {
            var calc = new Calc();
            calc.Add("1");
            calc.Add("2");
            calc.Add("+");
            calc.Add("2");
            calc.Add("1");
            calc.Add("+");
            Assert.AreEqual(calc.CurrentNumber, 33);
        }

        [TestMethod]
        public void マイナス計算()
        {
            var calc = new Calc();
            calc.Add("2");
            calc.Add("2");
            calc.Add("-");
            calc.Add("2");
            calc.Add("1");
            calc.Add("+");
            Assert.AreEqual(calc.CurrentNumber, 1);
        }
    }
}