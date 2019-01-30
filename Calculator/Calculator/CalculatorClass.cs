using System;

namespace Calculator
{
    public class CalculatorClass
    {
        private double result = 0;
        public double Addition(double a, double b)
        {
            result = a + b;
            return result;
        }

        public double Subtraction(double a, double b)
        {
            result = a - b;
            return result;
        }

        public double Multiplication(double a, double b)
        {
            result = a * b;
            return result;
        }

        public double Power(double x, double exp)
        {
            result = Math.Pow(x, exp);
            return result;
        }
    }
}
