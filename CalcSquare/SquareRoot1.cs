using System;
using IOperationCalc;

namespace CalcSquare
{
    public class SquareRoot1 : IOpWithOneArgorTwo
    {
        public double Evaluate(double firstNum)
        {
            return Math.Sqrt(firstNum);
        }

        public double Evaluate(double firstNum, double secondNum)
        {
            throw new NotImplementedException();
        }
    }
}
