using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{ 
    public class CalculatorOp
    {
        public readonly Dictionary<string, IMathOperation> RegisteredOperations = new();
        public double Calculate(string op, double op1, double op2)
        {
            if (!RegisteredOperations.ContainsKey(op))
                throw new ArgumentException(string.Format("Operation {0} is invalid", op));
            var result = RegisteredOperations[op].Evaluate(op1, op2);
            return result;
        }
        public double Calculate(string op, double op1)
        {
            if (!RegisteredOperations.ContainsKey(op))
                throw new ArgumentException(string.Format("Operation {0} is invalid", op));
            var result = RegisteredOperations[op].Evaluate(op1);
            return result;
        }
    }
}
