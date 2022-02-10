using System;
using CalcSum;
using CalcMinus;
using CalcDiv;
using CalcMult;
using CalcSquare;
using Calculator;
using IOperationCalc;


namespace CalcConsole
{

    class Program
    {

        static void Main(string[] args)
        {
            var calcOp = new CalculatorOp();
            calcOp.RegisteredOperations.Add("+", new Sum());
            calcOp.RegisteredOperations.Add("-", new Minus());
            calcOp.RegisteredOperations.Add("/", new Div());
            calcOp.RegisteredOperations.Add("*", new Mult());
            calcOp.RegisteredOperations.Add("s", new SquareRoot1());
            while (true)
            {
                try
                {
                    Console.Write("Введите 1 число ");
                    var firstNum = double.Parse(Console.ReadLine());
                    if ((firstNum > 99999999999))
                    {
                        Console.WriteLine("Нельзя вводить число больше 999999999");
                        Console.ReadLine();
                        continue;
                    }
                    Console.Write("Введите действие (+,*,-,/,s(корень)) ");
                    var action = Console.ReadLine();
                    Console.WriteLine();
                    if (action == "s")
                    {
                        calcOp.Calculate(action, firstNum);
                        System.Console.WriteLine($"{firstNum}{action}={calcOp.Calculate(action, firstNum)}");
                    }
                    Console.Write("Введите 2 число ");
                    var secondNum = double.Parse(Console.ReadLine());
                    System.Console.WriteLine($"{firstNum}{action}{secondNum}={calcOp.Calculate(action, firstNum, secondNum)}");
                }
                catch (Exception ex)
                {

                    System.Console.WriteLine(ex.Message);
                }
            }
        }
    }
}