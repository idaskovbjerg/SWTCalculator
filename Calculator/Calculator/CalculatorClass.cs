﻿using System;
using NUnit.Framework;

namespace Calculator
{
    public class CalculatorClass
    {
        private double result = 0;

        public double Addition(double a, double b)
        {
            return a + b;
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

            if (b != 0)
            {
                return a / b;
            }
            else
            {
                throw new ArgumentException("Cannot divide by zero");
            }
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
            if (divisor != 0)
            {
                Accumulator /= divisor;
                return Accumulator;
            }
            else
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
        }

        public double Power(double exponent)
        {
            if (exponent >= 0 || Accumulator != 0)
            {
                Accumulator = Math.Pow(Accumulator, exponent);
                return Accumulator;
            }
            else
            {
                throw new ArgumentException("Cannot use negative exponent while Accumulator is zero");
            }
        }

        public double Accumulator { get; private set; } = 0;

        public void Clear()
        {
            Accumulator = 0;
        }
    }
}
