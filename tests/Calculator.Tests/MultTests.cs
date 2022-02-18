using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace Calculator.Tests
{
    [TestClass]
    public class MultTests
    {
        [TestMethod]
        public void Mult_Zero_Numbers_Operation()
        {
            double v1 = 0;
            double v2 = 10;
            var expected = 0;

            var calc = new Mult();

            var result = calc.Evaluate(v1, v2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Mult_Negative_Numbers_Operation()
        {
            double v1 = -562.9323;
            double v2 = 5456.78623;
            var expected = -3071801.2230622293;

            var calc = new Mult();

            var result = calc.Evaluate(v1, v2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Mult_Positive_Numbers_Operation()
        {
            double v1 = 35.786;
            double v2 = 74.8952;
            var expected = 2680.1996272;

            var calc = new Mult();

            var result = calc.Evaluate(v1, v2);
            Assert.AreEqual(expected, result);
        }

    }
}
