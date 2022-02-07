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
            double firstVal, secondVal = default;

            var calc = new CalcActions();
            var calcDiv = new Div();
            var calcMult = new Mult();
            var calcSqrt = new SquareRoot1();
            var calcOp = new CalculatorOp();
            Console.Write("Введите 1 число ");
            firstVal = double.Parse(Console.ReadLine());
            Console.Write("Введите 2 число ");
            secondVal = double.Parse(Console.ReadLine());

            calcOp.RegisteredOperations.Add("/", (IOpWithOneArgorTwo)calcDiv);
            var div = calcOp.Calculate("/", firstVal, secondVal);

            calc.DefineOperation("mod", (x, y) => x % y);
            var mod = calc.ComputeOperation("mod", firstVal, secondVal);

            calcOp.RegisteredOperations.Add("*", (IOpWithOneArgorTwo)calcMult);
            var mult = calcOp.Calculate("*", firstVal, secondVal);

            calcOp.RegisteredOperations.Add("s", (IOpWithOneArgorTwo)calcSqrt);
            var sqrt = calcOp.Calculate("s", firstVal);





            while (true)
            {
                try
                {
                    
                
             
                    double firstNum, secondNum = 0;
                    string action;
                    Console.Write("Введите 1 число ");
                    firstNum = double.Parse(Console.ReadLine());
                    if ((firstNum > 99999999999) || (firstNum == 0))
                    {
                        Console.WriteLine("Нельзя вводить число больше 999999999 и 0");
                        Console.ReadLine();
                        continue;
                    }
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
                            Console.WriteLine("{0}*{1}={2}", firstNum, secondNum, calc.Mult(firstNum, secondNum));
                            break;
                        case "/":
                            try
                            {
                                if (secondNum == 0)
                                    throw new DivideByZeroException();
                                Console.WriteLine("{0}/{1}={2}", firstNum, secondNum, calcDiv.Evaluate(firstNum, secondNum));
                            }
                            catch (DivideByZeroException)
                            {
                                Console.WriteLine("Делить на ноль нельзя");

                            }
                            break;
                        case "s":
                            Console.WriteLine("Корень({0})={1}", firstNum, calcSqrt.Evaluate(firstNum));
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



