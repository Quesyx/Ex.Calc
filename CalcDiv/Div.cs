using System;
using IOperationCalc;

namespace CalcDiv
{
    public class Div : IOperation
    {
        public double firstNum,secondNum;
        public double Evaluate()
        {
            return firstNum/secondNum;
        }
    }
}
