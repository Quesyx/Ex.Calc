using System;
using IOperationCalc;

namespace CalcSum
{
    public class Sum : IOpWithOneArgorTwo
    {
        public double Evaluate(double firstNum)
        {
            throw new NotImplementedException();
        }

        public double Evaluate(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }
    }
}
