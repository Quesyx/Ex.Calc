using System;
using System.Collections.Generic;
using IOperationCalc;
using CalcDiv;
namespace Calculator
{
    public class CalculatorOp
    {

        public readonly Dictionary<string, IOpWithOneArgorTwo> RegisteredOperations=new();

    public double Calculate(string op, double op1, double op2){
    if (!RegisteredOperations.ContainsKey(op))
    throw new ArgumentException(string.Format("Operation {0} is invalid",op));
    return RegisteredOperations[op].Evaluate(op1,op2);

    }

    }
}
