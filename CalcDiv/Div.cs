using System;
using IOperationCalc;

namespace CalcDiv
{
    public class Div : IOperation
    {
        public double Evaluate(double firstNum, double secondNum)
        {
            return firstNum/secondNum;
        }
    }
}
