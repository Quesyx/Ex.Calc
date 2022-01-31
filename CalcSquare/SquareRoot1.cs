using System;
using IOperationCalc;

namespace CalcSquare
{
    public class SquareRoot1 : IOpOneArg
    {
        public double Evaluate(double firstNum)
        {
            return Math.Sqrt(firstNum);
        }
    }
}
