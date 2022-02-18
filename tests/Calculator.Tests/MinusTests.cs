using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class MinusTests
    {
        [TestMethod]
        public void Minus_Negative_Numbers_Operation()
        {
            double v1 = -4;
            double v2 = 5;
            var expected = -9;
            var calc = new Minus();

            var result = calc.Evaluate(v1, v2);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Minus_Positive_Numbers_Operation()
        {
            double v1 = 357.2;
            double v2 = 67.8;
            var expected = 289.4;
            var calc = new Minus();

            var result = calc.Evaluate(v1, v2);

            Assert.AreEqual(expected, result);

        }
    }
}
