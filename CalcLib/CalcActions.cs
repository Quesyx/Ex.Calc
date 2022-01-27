using System;

namespace CalcLib
{
    public class CalcActions
    {
        public double Sum(double a, double b)
        {
            return a + b;
        }
        public double Diff(double a, double b)
        {
            return a - b;
        }
        public double Mult(double a, double b)
        {
            return a * b;
        }
        public double Div(double a, double b)
        {
            return a / b;
        }
        public double SquareRoot(double a)
        {
            return Math.Sqrt(a);
        }
    }
}
