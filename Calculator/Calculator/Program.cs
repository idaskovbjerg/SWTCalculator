using System;
using System.Linq;

namespace Calculator //https://codereview.stackexchange.com/questions/126141/first-program-a-simple-calculator
{
    class Program
    {
        
        private static readonly string[] operations = { "+", "-", "*", "/", "^"};
        public static CalculatorClass calc_ { get; set; } = new CalculatorClass();
        static void Main(string[] args)
        {
            Console.WriteLine("Use accumulator? [Y]/[N]");
            while (Console.ReadLine() == "Y")
            {
                CalculatorAccumulator();
                Console.WriteLine("Continue to use accumulator? [Y]/[N]");

            }
            calc_.Clear();
            Console.WriteLine("Do you wanna use the  normal calculator? [Y]/[N]");
            while (Console.ReadLine() == "Y")
            {
                Calculator();
                Console.WriteLine("New calculation? [Y]/[N]");
            }
            Console.WriteLine("Do you wanna use the accumulator? [Y]/[N]");
            while (Console.ReadLine() == "Y")
            {
                CalculatorAccumulator();
                Console.WriteLine("Continue to use accumulator? [Y]/[N]");
            }
            calc_.Clear();
        }

        
        static void CalculatorAccumulator()
        {

            double result = 0.0;
            string stringOperation =
                SetOperation(
                    "Enter the operation: + (addition), - (subtraction), * (multiplication), / (division) or ^ (power):");

            double firstNumber;

            switch (stringOperation)
            {
                case "+":
                case "addition":
                    firstNumber = SetNumber("First number : ");
                    //result = calc.Addition(firstNumber);
                    Console.WriteLine("Result: {0} {1} {2} = {3}", calc_.Accumulator, stringOperation, firstNumber, calc_.Addition(firstNumber));
                    break;
                case "-":
                case "subtraction":
                    firstNumber = SetNumber("First number : ");
                    
                    Console.WriteLine("Result: {0} {1} {2} = {3}", calc_.Accumulator, stringOperation, firstNumber, calc_.Subtraction(firstNumber));
                    break;
                case "*":
                case "multiplication":
                    firstNumber = SetNumber("First number : ");
                    
                    Console.WriteLine("Result: {0} {1} {2} = {3}", calc_.Accumulator, stringOperation, firstNumber, calc_.Multiplication(firstNumber));
                    break;
                case "/":
                case "division":
                    firstNumber = SetNumber("First number : ");

                    Console.WriteLine("Result: {0} {1} {2} = {3}", calc_.Accumulator, stringOperation, firstNumber, calc_.Division(firstNumber));
                    break;
                case "^":
                case "power":
                    firstNumber = SetNumber("First number : ");
                    
                    Console.WriteLine("Result: {0}{1}{2} = {3}", calc_.Accumulator, stringOperation, firstNumber, calc_.Power(firstNumber));
                    break;
            }
        }

        static void Calculator()
        {
            CalculatorClass calc = new CalculatorClass();

            double result = 0.0;
            string stringOperation =
                SetOperation(
                    "Enter the operation: + (addition), - (subtraction), * (multiplication), / (division) or ^ (power):");

            double firstNumber;
            double secondNumber;

            switch (stringOperation)
            {
                case "+":
                case "addition":
                    firstNumber = SetNumber("First number : ");
                    secondNumber = SetNumber("Second number: ");
                    result = calc.Addition(firstNumber,secondNumber);
                    Console.WriteLine("Result: {0} {1} {2} = {3}", firstNumber, stringOperation, secondNumber, result);
                    break;
                case "-":
                case "subtraction":
                    firstNumber = SetNumber("First number : ");
                    secondNumber = SetNumber("Second number: ");
                    result = calc.Subtraction(firstNumber, secondNumber);
                    Console.WriteLine("Result: {0} {1} {2} = {3}", firstNumber, stringOperation, secondNumber, result);
                    break;
                case "*":
                case "multiplication":
                    firstNumber = SetNumber("First number : ");
                    secondNumber = SetNumber("Second number: ");
                    result = calc.Multiplication(firstNumber, secondNumber);
                    Console.WriteLine("Result: {0} {1} {2} = {3}", firstNumber, stringOperation, secondNumber, result);
                    break;
                case "/":
                case "division":
                    firstNumber = SetNumber("First number : ");
                    secondNumber = SetNumber("Second number: ");
                    result = calc.Division(firstNumber, secondNumber);
                    Console.WriteLine("Result: {0} {1} {2} = {3}", firstNumber, stringOperation, secondNumber, result);
                    break;
                case "^":
                case "power":
                    firstNumber = SetNumber("First number : ");
                    secondNumber = SetNumber("Second number: ");
                    result = calc.Power(firstNumber,secondNumber);
                    Console.WriteLine("Result: {0}{1}{2} = {3}", firstNumber, stringOperation, secondNumber, result);
                    break;
            }
        }

        private static double SetNumber(string outputText)
        {
            double parse;
            Console.Write(outputText);
            string tempInput = Console.ReadLine();
            while (!double.TryParse(tempInput, out parse))
            {
                Console.WriteLine("Incorrect input !");
                Console.Write(outputText);
                tempInput = Console.ReadLine();
            }

            return double.Parse(tempInput);
        }
        private static string SetOperation(string outputText)
        {
            Console.Write(outputText);
            string tempInput = Console.ReadLine();
            while (!IsValidOperation(tempInput))
            {
                Console.WriteLine("Incorrect input !");
                Console.Write(outputText);
                tempInput = Console.ReadLine();
            }
            return tempInput;
        }
        private static bool IsValidOperation(string input)
        {
            return operations.Contains(input);
        }
    }
}
