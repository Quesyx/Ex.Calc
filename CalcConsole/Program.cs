using System;
using CalcLib;
using CalcDiv;
using CalcSquare;
using Calculator;
using System.Collections.Generic;


namespace CalcConsole
{

    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                try
                {
                    double firstNum, secondNum = 0;



                    Console.Write("Введите 1 число ");
                    firstNum = double.Parse(Console.ReadLine());
        
                    string action;
                    Console.Write("Введите действие (+, -, *, /, s(Корень)) ");
                    action = Console.ReadLine();
                    Console.WriteLine();
                    if (action != "s")
                    {
                        Console.Write("Введите 2 число ");
                        secondNum = double.Parse(Console.ReadLine());
                    }

                    var calc = new CalcActions();
                    var calcDiv = new Div();
                    var calcSqrt = new SquareRoot1();
                    var op= new Dictionary<string,object>();
            var MathOp=new CalculatorOp();
            MathOp.SetOperation(op);
           op.Add("/",calcDiv.Evaluate(firstNum,secondNum));
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
                        op.Add("/",calcDiv.Evaluate(firstNum,secondNum));
                            try
                           {
                                if (secondNum == 0)
                                    throw new DivideByZeroException();
                                Console.WriteLine("{0}/{1}={2}", firstNum, secondNum);
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
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }
        }

    }
}

