using System;
using IOperationCalc;

namespace CalcDiv
{
    public class Div : IOpWithOneArgorTwo
    {

        public double Evaluate(double firstNum, double secondNum)
        {
                try
            {
                if (secondNum == 0)
                    throw new DivideByZeroException();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Делить на ноль нельзя!");
            }
 
            return firstNum / secondNum;
        }

        public double Evaluate(double firstNum)
        {
            throw new NotImplementedException();
        }
    }
}
