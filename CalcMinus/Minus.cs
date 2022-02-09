using System;
using IOperationCalc;
namespace CalcMinus
{
    public class Minus : IOpWithOneArgorTwo
    {
        public double Evaluate(double firstNum)
        {
            throw new NotImplementedException();
        }

        public double Evaluate(double firstNum, double secondNum)
        {
            return firstNum - secondNum;
        }
    }
}
