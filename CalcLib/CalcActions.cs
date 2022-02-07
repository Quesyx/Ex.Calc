using System;
using System.Collections.Generic;
using IOperationCalc;

namespace CalcLib
{
    public class CalcActions
    {
        private Dictionary<string, Func<double, double, double>> _operations;

        public CalcActions()
        {
            _operations = new Dictionary<string, Func<double, double, double>>
    {
        { "+", this.Sum },
        { "-", this.Diff },
        { "*", this.Mult },
        { "/", this.Div },
    };
        }

        public double ComputeOperation(string op, double op1, double op2)
        {
            if (!_operations.ContainsKey(op))
                throw new ArgumentException(string.Format("Operation {0} is invalid", op), "op");
            return _operations[op](op1, op2);
        }
        public void DefineOperation(string op, Func<double, double, double> body)
        {
            if (_operations.ContainsKey(op))
                throw new ArgumentException(string.Format("Operation {0} already exists", op), "op");
            _operations.Add(op, body);
        }
        public double Sum(double a, double b)
        {
            return a + b;
        }
        public double Diff(double a, double b)
        {
            return a - b;
        }
        public double Mult(double a, double b)
        {
            return a * b;
        }
        public double Div(double a, double b)
        {
            try
            {
                if (b == 0)
                    throw new DivideByZeroException();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Делить на ноль нельзя");

            }
            return a / b;
        }
        public double SquareRoot(double a)
        {
            return Math.Sqrt(a);
        }
    }
}
