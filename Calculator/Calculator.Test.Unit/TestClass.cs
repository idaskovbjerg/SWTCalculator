using System;
using NUnit.Framework;


namespace Calculator.Test.Unit
{

    [TestFixture]
    public class TestClass
    {
        private readonly Calculator.CalculatorClass calculator;

        public TestClass()
        {
            calculator = new CalculatorClass();
        }

        [Test]
        public void AdditionTest()
        {
            var x = calculator.Addition(2, 2);
            Assert.That(x,Is.EqualTo(4));
        }
        [Test]
        public void AdditionTest2()
        {
            var x = calculator.Addition(-30, 27);
            Assert.That(x, Is.EqualTo(-30+27));
        }

        [Test]
        public void SubtractionTest()
        {
            var x = calculator.Subtraction(29, 37);
            Assert.That(x,Is.EqualTo(-8));
        }
        [Test]
        public void SubtractionTest2()
        {
            var x = calculator.Subtraction(2936, 37);
            Assert.That(x, Is.EqualTo(2936-37));
        }

        [Test]
        public void MultiplicationTest()
        {
            var x = calculator.Multiplication(3.7, -3.3);
            Assert.That(x,Is.EqualTo(3.7*-3.3));
        }
        [Test]
        public void MultiplicationTest2()
        {
            var x = calculator.Multiplication(37, 3.3);
            Assert.That(x, Is.EqualTo(37 * 3.3));
        }

        [TestCase(3, 2, 6)]
        [TestCase(-3, -2, 6)]
        [TestCase(-3, 2, -6)]
        [TestCase(3, -2, -6)]
        [TestCase(0, -2, 0)]
        [TestCase(-2, 0, 0)]
        [TestCase(0, 0, 0)]
        public void Multiply_MultiplyNunmbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(calculator.Multiplication(a, b), Is.EqualTo(result));
        }

        [Test]
        public void PowerTest()
        {
            var x = calculator.Power(37, 3.3);
            Assert.That(x, Is.EqualTo(149646.2).Within(0.01));
        }

        [Test]
        public void PowerTest2()
        {
            var x = calculator.Power(37, -3.3);
            Assert.That(x, Is.EqualTo(Math.Pow(37,-3.3)).Within(0.01));
        }
        [Test]
        public void PowerTest3()
        {
            var x = calculator.Power(-37, -3);
            Assert.That(x, Is.EqualTo(Math.Pow(-37,-3)).Within(0.01));
        }

        [TestCase(2, 2)]
        [TestCase(2, 2)]
        public void Addition_ResultIsCorrect(double a, double result)
        {
            Assert.That(calculator.Addition(a), Is.EqualTo(result));
        }
    }
}
