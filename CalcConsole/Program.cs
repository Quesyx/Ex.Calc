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

            calcOp.RegisteredOperations.Add("+", (IOpWithOneArgorTwo)new Sum());

            calcOp.RegisteredOperations.Add("-", (IOpWithOneArgorTwo)new Minus());

            calcOp.RegisteredOperations.Add("/", (IOpWithOneArgorTwo)new Div());

            calcOp.RegisteredOperations.Add("*", (IOpWithOneArgorTwo)new Mult());

            calcOp.RegisteredOperations.Add("s", (IOpWithOneArgorTwo)new SquareRoot1());



            while (true)
            {
                try
                {
                    double firstNum, secondNum = default;

                    Console.Write("Введите 1 число ");
                    firstNum = double.Parse(Console.ReadLine());
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
                    }

                    Console.Write("Введите 2 число ");
                    secondNum = double.Parse(Console.ReadLine());
                    calcOp.Calculate(action, firstNum, secondNum);

                }
                catch (Exception ex)
                {

                    System.Console.WriteLine(ex.Message);
                }

            }

        }

    }

}



