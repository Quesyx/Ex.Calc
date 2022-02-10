using System;
using IOperationCalc;

namespace CalcDiv
{
    public class Div : IOpWithOneArgorTwo
    {

        public double Evaluate(double firstNum, double secondNum)
        {
            if (secondNum == 0)
                throw new DivideByZeroException();
            return firstNum / secondNum;
        }

        public double Evaluate(double firstNum)
        {
            throw new NotImplementedException();
        }
    }
}
