using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReactCalc;

namespace TestCalc
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestSum()
        {
            var calc = new Calc();
            //var x = calc.Sum(1, 2);
            var x = calc.Execute("Sum", new[] { 1.0, 2.0 });

            Assert.AreEqual(x, 3);
            Assert.AreEqual(calc.Execute("Sum", new[] { 0.0, 0.0 }), 0);
            Assert.AreEqual(calc.Execute("Sum", new[] { -1.0, 2.0 }), 1);
            Assert.AreEqual(calc.Execute("Sum", new[] { 3.0, 3.0 }), 6);
        }

        [TestMethod]
        public void TestDiv()
        {
            var calc = new Calc();
            var x = calc.Div(2, 2);
            var y = calc.Div(2, 0);

            Assert.AreEqual(x, 1);
            Assert.AreEqual(y, double.PositiveInfinity);
        }

        [TestMethod]
        public void TestSqrt()
        {
            var calc = new Calc();
            var x = calc.Sqrt(4);

            Assert.AreEqual(x, 2);
            Assert.AreEqual(calc.Sqrt(0), 0);
            Assert.AreEqual(calc.Sqrt(9), 3);
        }
    }
}
