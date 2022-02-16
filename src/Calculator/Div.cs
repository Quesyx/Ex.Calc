using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Div : IMathOperation
    {
        public double Evaluate(double firstNum)
        {
            throw new NotImplementedException();
        }

        public double Evaluate(double firstNum, double secondNum)
        {
            if (secondNum == 0)
                throw new DivideByZeroException();
            return firstNum / secondNum;
        }
    }
}
