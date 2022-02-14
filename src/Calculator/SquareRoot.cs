using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.src.Calculator
{
   public class SquareRoot : IMathOperation
    {
        public double Evaluate(double firstNum)
        {
           return Math.Sqrt(firstNum);
        }

        public double Evaluate(double firstNum, double secondNum)
        {
            throw new NotImplementedException();
        }
    }
}
