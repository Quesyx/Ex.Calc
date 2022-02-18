using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class PlusTests
    {
        [TestMethod]
        public void Plus_Negative_Number_Operation()
        {
            double v1 = -34;
            double v2 = 99;
            var expected = 65;

            var calc = new Sum();

            var result = calc.Evaluate(v1, v2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Plus_Positive_Number_Operation()
        {
            double v1 = 1111111;
            double v2 = 1111111;
            var expected = 2222222;

            var calc = new Sum();

            var result = calc.Evaluate(v1, v2);
            Assert.AreEqual(expected, result);
        }
    }
}
