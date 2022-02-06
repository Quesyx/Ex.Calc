using System;
using System.Collections.Generic;
using IOperationCalc;
using CalcDiv;
namespace Calculator
{
    public class CalculatorOp
    {




   public void Call(string op,double op1,double op2)
   
  {
  
      var result =RegisteredOperations[op].Evaluate(op1,op2);
            System.Console.WriteLine($"{op1}{op}{op2}={result}");

  }
     public void Call(string op,double op1)
   
  {
  
      var result =RegisteredOperations[op].Evaluate(op1);
            System.Console.WriteLine(result);

  }
  
        public readonly Dictionary<string, IOpWithOneArgorTwo> RegisteredOperations=new();
      

    public double Calculate(string op, double op1, double op2){
    if (!RegisteredOperations.ContainsKey(op))
    throw new ArgumentException(string.Format("Operation {0} is invalid",op));
    Call(op,op1,op2);
    return RegisteredOperations[op].Evaluate(op1,op2);

    }
    public double Calculate(string op, double op1)
    {

          if (!RegisteredOperations.ContainsKey(op))
    throw new ArgumentException(string.Format("Operation {0} is invalid",op));
    Call(op,op1);
  return RegisteredOperations[op].Evaluate(op1);


    }
    

    }
}
