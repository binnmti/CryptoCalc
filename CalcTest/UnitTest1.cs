using CryptoCalc;

namespace CalcTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void êîéöÇæÇØÇí«â¡()
        {
            var calc = new Calc();
            calc.Add("1");
            calc.Add("2");
            calc.Add("3");
            Assert.AreEqual(calc.CurrentNumber, 123);
        }

        [TestMethod]
        public void åvéZÇí«â¡()
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
        public void ãLçÜé~Çﬂ()
        {
            var calc = new Calc();
            calc.Add("1");
            calc.Add("2");
            calc.Add("+");
            Assert.AreEqual(calc.CurrentNumber, 12);
        }

        [TestMethod]
        public void ãLçÜé~Çﬂ2()
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
    }
}