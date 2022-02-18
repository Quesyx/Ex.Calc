using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Calculator.Tests
{
    [TestClass]
    public class CalcOpTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Invalid currency")]
        public void Call_Exception_If_SymbolUnknown()
        {
            double v1 = 4;
            string op = "hh";
            var calc = new CalculatorOp();

            calc.Calculate(op, v1);
        }
        [TestMethod]
        public void Call_Registred_Operation_WithTransferedSymbol()
        {
            double v1 = 4;
            double v2 = 5;
            var calc = new CalculatorOp();
            calc.RegisteredOperations.Add("*", new Mult());

            calc.Calculate("*", v1, v2);
        }

    }
}
