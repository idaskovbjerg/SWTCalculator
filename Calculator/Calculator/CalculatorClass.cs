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

        public double Division(double a, double b)
        {
            result = a / b;
            return result;
        }

        public double Power(double x, double exp)
        {
            result = Math.Pow(x, exp);
            return result;
        }

        public double Addition(double addend)
        {
            Accumulator += addend;
            return Accumulator;
        }

        public double Subtraction(double subtractor)
        {
            Accumulator -= subtractor;
            return Accumulator;
        }

        public double Multiplication(double multiplier)
        {
            Accumulator *= multiplier;
            return Accumulator;
        }

        public double Division(double divisor)
        {
            Accumulator /= divisor;
            return Accumulator;
        }

        public double Power(double exponent)
        {
            Accumulator = Math.Pow(Accumulator, exponent);
            return Accumulator;
        }


        public double Accumulator { get; private set; } = 0;

        public void Clear()
        {
            Accumulator = 0;
        }
    }
}
