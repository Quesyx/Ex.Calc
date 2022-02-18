using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator.Tests
{
    [TestClass]
    public class DivTests
    {

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]

        public void Divide_Numbers_ReturnsZeroException()
        {
            double v1 = 4;
            double v2 = 0;

            var calc = new Div();

            calc.Evaluate(v1, v2);


        }
        [TestMethod]
        public void Divide_Negative_Numbers()
        {
            double v1 = -4;
            double v2 = 2;
            double expected = -2;
            var calc = new Div();

            double result = calc.Evaluate(v1, v2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Divide_Positive_Numbers()
        {
            double v1 = 350;
            double v2 = 65;
            double expected = 5.384615384615384615385;
            var calc = new Div();

            double result = calc.Evaluate(v1, v2);
            Assert.AreEqual(expected, result);
        }

    }

}

