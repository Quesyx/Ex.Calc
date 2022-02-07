using System;
using CalcLib;
using CalcDiv;
using CalcMult;
using CalcSquare;
using Calculator;
using IOperationCalc;
using System.Collections.Generic;


namespace CalcConsole
{

    class Program
    {

        static void Main(string[] args)
        {
            var calc = new CalcActions();
            var calcDiv = new Div();
            var calcMult = new Mult();
            var calcSqrt = new SquareRoot1();
            var calcOp = new CalculatorOp();

            calcOp.RegisteredOperations.Add("/", (IOpWithOneArgorTwo)calcDiv);

            calcOp.RegisteredOperations.Add("*", (IOpWithOneArgorTwo)calcMult);

            calcOp.RegisteredOperations.Add("s", (IOpWithOneArgorTwo)calcSqrt);

            calc.DefineOperation("mod", (x, y) => x % y);


            while (true)
            {
                try
                {
                    double firstNum, secondNum = default;

                    Console.Write("Введите 1 число ");
                    firstNum = double.Parse(Console.ReadLine());
                    if ((firstNum > 99999999999) || (firstNum == 0))
                    {
                        Console.WriteLine("Нельзя вводить число больше 999999999 и 0");
                        Console.ReadLine();
                        continue;
                    }
                    string action;
                    Console.Write("Введите действие (+, -, *, /, s(Корен)) ");
                    action = Console.ReadLine();
                    Console.WriteLine();
                    if (action != "s")
                    {
                        Console.Write("Введите 2 число ");
                        secondNum = double.Parse(Console.ReadLine());
                    }


                    switch (action)
                    {
                        case "+":
                            Console.WriteLine("{0}+{1}={2}", firstNum, secondNum, calc.Sum(firstNum, secondNum));
                            break;
                        case "-":
                            Console.WriteLine("{0}-{1}={2}", firstNum, secondNum, calc.Diff(firstNum, secondNum));
                            break;
                        case "*":
                            calcOp.Calculate("*", firstNum, secondNum);
                            break;
                        case "/":
                            try
                            {
                                if (secondNum == 0)
                                    throw new DivideByZeroException();
                                calcOp.Calculate("/", firstNum, secondNum);
                            }
                            catch (DivideByZeroException)
                            {
                                Console.WriteLine("Делить на ноль нельзя");

                            }
                            break;
                        case "s":
                            calcOp.Calculate("s", firstNum);
                            break;
                        default:
                            Console.WriteLine("Ошибка, Некорректное действие!");
                            break;


                    }
                }
                catch (Exception ex)
                {

                    System.Console.WriteLine(ex.Message);
                }

            }


        }



    }

}



