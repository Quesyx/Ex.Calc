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
            var calcSum = new Sum();
            var calcMinus = new Minus();
            var calcDiv = new Div();
            var calcMult = new Mult();
            var calcSqrt = new SquareRoot1();
            var calcOp = new CalculatorOp();

            calcOp.RegisteredOperations.Add("+", (IOpWithOneArgorTwo)calcSum);

            calcOp.RegisteredOperations.Add("-", (IOpWithOneArgorTwo)calcMinus);

            calcOp.RegisteredOperations.Add("/", (IOpWithOneArgorTwo)calcDiv);

            calcOp.RegisteredOperations.Add("*", (IOpWithOneArgorTwo)calcMult);

            calcOp.RegisteredOperations.Add("s", (IOpWithOneArgorTwo)calcSqrt);



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
                    string action;
                    Console.Write("Введите действие (+,*,-,/,s(корень)) ");
                    action = Console.ReadLine();
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



