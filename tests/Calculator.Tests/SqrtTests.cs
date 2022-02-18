using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class SqrtTests
    {
        [TestMethod]
        public void Check_BigSquare_Number()
        {
            double v1 = -4;
            double expected = double.NaN;
            var calc = new SquareRoot();

            var result = calc.Evaluate(v1);
            Assert.AreEqual(expected, result);
        }
    }
}
