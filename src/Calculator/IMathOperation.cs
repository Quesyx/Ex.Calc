using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.src.Calculator
{
    public interface IMathOperation
    {
         double Evaluate(double firstNum);
         double Evaluate(double firstNum, double secondNum);
    }
}
