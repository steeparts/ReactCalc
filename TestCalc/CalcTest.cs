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
            var x = calc.Execute("Sum", new[] { 1.0, 2.0 });

            Assert.AreEqual(x, 3);
            Assert.AreEqual(calc.Execute("Sum", new[] { 0.0, 0.0 }), 0);
            Assert.AreEqual(calc.Execute("Sum", new[] { -1.0, 2.0 }), 1);
            Assert.AreEqual(calc.Execute("Sum", new[] { 3.0, 3.0 }), 6);
        }

        [TestMethod]
        public void TestDif()
        {
            var calc = new Calc();
            var x = calc.Execute("Dif", new[] { 100.0, 82.0 });

            Assert.AreEqual(x, 18);
            Assert.AreEqual(calc.Execute("Dif", new[] { 0.0, 0.0 }), 0);
            Assert.AreEqual(calc.Execute("Dif", new[] { -1.0, 2.0 }), -3);
            Assert.AreEqual(calc.Execute("Dif", new[] { 0.0, 3.0 }), -3);
        }

        [TestMethod]
        public void TestMul()
        {
            var calc = new Calc();
            var x = calc.Execute("Mul", new[] { 5.0, 8.0 });

            Assert.AreEqual(x, 40);
            Assert.AreEqual(calc.Execute("Mul", new[] { -10.0, -1.1 }), 11);
        }

        [TestMethod]
        public void TestDiv()
        {
            var calc = new Calc();
            var x = calc.Execute("Div", new[] { 5.0, 5.0 });

            Assert.AreEqual(x, 1);
            Assert.AreEqual(calc.Execute("Div", new[] { 100.0, 0.0 }), double.PositiveInfinity);
        }
    }
}
