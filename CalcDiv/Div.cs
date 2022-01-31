using System;
using IOperationCalc;

namespace CalcDiv
{
    public class Div : IOpTwoArg
    {

        public double Evaluate(double firstNum,double secondNum)
        {
            return firstNum/secondNum;
        }


    }
}
