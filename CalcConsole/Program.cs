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

                double firstVal, secondVal = default;
                System.Console.WriteLine("цифра 1-операция с одним числом\nцифра 2-операция с двумя числами");
                string chooseNumbers = Console.ReadLine();

                if (chooseNumbers == "1")
                {




                    System.Console.WriteLine("Введите 1 число");
                    firstVal = double.Parse(Console.ReadLine());
                    Console.Clear();
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
            }


        }

    }
}


