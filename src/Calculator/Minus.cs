using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   public class Minus : IMathOperation
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
