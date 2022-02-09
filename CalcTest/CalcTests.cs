using NUnit.Framework;
using CalcDiv;
using CalcMult;
using CalcSquare;
namespace CalcTest
{
    [TestFixture]
    public class CalcTests
    {
        [TestCase(2, 5, 10)]
        [TestCase(5, 3, 15)]
        [TestCase(12, 10, 120)]
        [TestCase(10, 3, 30)]
        public void Multiply_Numbers_ReturnsProduct(double a, double b, double expected)
        {
            var calc = new Mult();

            var actual = calc.Evaluate(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(6, 2, 3)]
        [TestCase(133, 1, 133)]
        [TestCase(35, 5, 7)]
        [TestCase(220, 2, 110)]
        public void Divide_Numbers_ReturnsQuotient(double a, double b, double expected)
        {
            var calc = new Div();

            double actual = calc.Evaluate(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(4, 2)]
        [TestCase(9, 3)]
        [TestCase(25, 5)]
        [TestCase(16, 4)]
        public void SquareRoot_Number_ReturnsResult(double d, double expected)
        {
            var calc = new SquareRoot1();

            double actual = calc.Evaluate(d);

            Assert.AreEqual(expected, actual);
        }

    }
}
