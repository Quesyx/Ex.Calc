﻿using System;
using CalcLib;
using CalcDiv;

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
                    var calc = new CalcActions();
                    var calcDiv = new Div();
                    calcDiv.firstNum=firstNum;
                    calcDiv.secondNum=secondNum;
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
                                Console.WriteLine("{0}/{1}={2}", calcDiv.firstNum, calcDiv.secondNum, calcDiv.Evaluate());
                            }
                            catch (DivideByZeroException)
                            {
                                Console.WriteLine("Делить на ноль нельзя");

                            }
                            break;
                        case "s":
                            Console.WriteLine("Корень({0})={1}", firstNum, calc.SquareRoot(firstNum));
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
