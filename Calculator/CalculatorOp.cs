using System;
using System.Collections.Generic;
using IOperationCalc;
namespace Calculator
{
    public class CalculatorOp
    {

        public readonly Dictionary<string, IOpWithOneArgorTwo> RegisteredOperations = new();

        public double Calculate(string op, double op1, double op2)
        {
            var result = RegisteredOperations[op].Evaluate(op1, op2);
            if (!RegisteredOperations.ContainsKey(op))
                throw new ArgumentException(string.Format("Operation {0} is invalid", op));
            try
            {
                if (op2 == 0)
                    throw new DivideByZeroException();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Делить или умножать на ноль нельзя!");
            }
            return result;
        }
        public double Calculate(string op, double op1)
        {
            var result = RegisteredOperations[op].Evaluate(op1);
            if (!RegisteredOperations.ContainsKey(op))
                throw new ArgumentException(string.Format("Operation {0} is invalid", op));
            return result;
        }
    }
}
