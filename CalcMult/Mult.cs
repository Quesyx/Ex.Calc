using System;
using IOperationCalc;

namespace CalcMult
{
    public class Mult : IOpWithOneArgorTwo
    {
        public double Evaluate(double firstNum)
        {
            throw new NotImplementedException();
        }

        public double Evaluate(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }
    }
}
