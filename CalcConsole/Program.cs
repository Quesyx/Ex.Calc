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
       
        
            
            while (true)
            {
                       while (true)
            {

            double firstVal, secondVal = default;
            System.Console.WriteLine("цифра 1-операция с одним числом\nцифра 2-операция с двумя числами");
            string chooseNumbers = Console.ReadLine();
            if (chooseNumbers == "1")
            {
                System.Console.WriteLine("Введите 1 число");
                firstVal = double.Parse(Console.ReadLine());
                var calcOp = new CalculatorOp();
                var calcSqrt = new SquareRoot1();
                calcOp.RegisteredOperations.Add("s", (IOpWithOneArgorTwo)calcSqrt);
                var sqrt = calcOp.Calculate("s", firstVal);


            }
            else if (chooseNumbers == "2")
            {

                var calcOp = new CalculatorOp();
                var calcDiv = new Div();
                var calcMult = new Mult();
                var calc = new CalcActions();
                System.Console.WriteLine("Введите 1 число");
                firstVal = double.Parse(Console.ReadLine());
                System.Console.WriteLine("Введите 2 число");
                secondVal = double.Parse(Console.ReadLine());
                calcOp.RegisteredOperations.Add("/", (IOpWithOneArgorTwo)calcDiv);
                var div = calcOp.Calculate("/", firstVal, secondVal);

                calc.DefineOperation("mod", (x, y) => x % y);
                var mod = calc.ComputeOperation("mod", firstVal, secondVal);

                calcOp.RegisteredOperations.Add("*", (IOpWithOneArgorTwo)calcMult);
                var mult = calcOp.Calculate("*", firstVal, secondVal);


            } 
Console.ReadLine();
                try
                {
                    double firstNum, secondNum = 0;

System.Console.WriteLine("switch opeartions");
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
                    var calcMult = new Mult();
                    var calcSqrt = new SquareRoot1();
                    var calcOp = new CalculatorOp();


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
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }
        }

    }
    }
}

