using System;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using NUnit.Framework.Internal;


namespace Calculator.Test.Unit
{

    [TestFixture]
    public class TestClass
    {
        private Calculator.CalculatorClass _uut;

        [SetUp]
        public void SetupTest()
        {
            _uut = new CalculatorClass();
        }

        [Test]
        public void Addition_PositiveNumber_ResultIsCorrect()
        {
            var x = _uut.Addition(2, 2);
            Assert.That(x,Is.EqualTo(4));
        }
        [Test]
        public void Addition_NegativeNumberFirst_ResultIsCorrect()
        {
            var x = _uut.Addition(-30, 27);
            Assert.That(x, Is.EqualTo(-30+27));
        }
        [Test]
        public void Addition_NegativeNumberLast_ResultIsCorrect()
        {
            var x = _uut.Addition(30, -27);
            Assert.That(x, Is.EqualTo(30 + (-27)));
        }
        

        [Test]
        public void Subtraction_PositiveNumber_ResultIsCorrect()
        {
            var x = _uut.Subtraction(29, 37);
            Assert.That(x,Is.EqualTo(-8));
        }
        [Test]
        public void Subtraction_NegativeNumberLast_ResultIsCorrect()
        {
            var x = _uut.Subtraction(2936, -37);
            Assert.That(x, Is.EqualTo(2936-(-37)));
        }
        [Test]
        public void Subtraction_NegativeNumberFirst_ResultIsCorrect()
        {
            var x = _uut.Subtraction(-2936, 37);
            Assert.That(x, Is.EqualTo(-2936 - 37));
        }

        [Test]
        public void Multiplication_NegativeNumberLast_ResultIsCorrect()
        {
            var x = _uut.Multiplication(3.7, -3.3);
            Assert.That(x,Is.EqualTo(3.7*-3.3));
        }
        [Test]
        public void Multiplication_NegativeNumberFirst_ResultIsCorrect()
        {
            var x = _uut.Multiplication(-3.7, 3.3);
            Assert.That(x, Is.EqualTo(-3.7 * 3.3));
        }
        [Test]
        public void Multiplication_PositiveNumber_ResultIsCorrect()
        {
            var x = _uut.Multiplication(37, 3.3);
            Assert.That(x, Is.EqualTo(37 * 3.3));
        }

        [TestCase(3, 2, 6)]
        [TestCase(-3, -2, 6)]
        [TestCase(-3, 2, -6)]
        [TestCase(3, -2, -6)]
        [TestCase(0, -2, 0)]
        [TestCase(-2, 0, 0)]
        [TestCase(-2.2, 2, -4.4)]
        [TestCase(0, 0, 0)]
        public void Multiplication_MultiplyNumbers_ResultIsCorrect(double a, double b, double result)
        {
            Assert.That(_uut.Multiplication(a, b), Is.EqualTo(result));
        }

        [TestCase(8, 2, 4)]
        [TestCase(8, -2, -4)]
        [TestCase(-16, -2, 8)]
        [TestCase(-1.6, -2, 0.8)]
        [TestCase(0, 16, 0)]
        public void Division_DivideNumbers_ResultIsCorrect(double a, double b, double result)
        {
            Assert.That(_uut.Division(a,b), Is.EqualTo(result));
        }

        [Test]
        public void Divide_DivideByZero_ThrowException()
        {
            Assert.Throws<ArgumentException>(() => _uut.Division(16, 0));

            // Assert.That(() => _uut.Division(16,0), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void Power_PositiveDecimalNumbers_ResultIsCorrect()
        {
            var x = _uut.Power(37, 3.3);
            Assert.That(x, Is.EqualTo(149646.2).Within(0.01));
        }

        [Test]
        public void Power_NegativeDecimalNumberLast_ResultIsCorrect()
        {
            var x = _uut.Power(37, -3.3);
            Assert.That(x, Is.EqualTo(Math.Pow(37,-3.3)).Within(0.01));
        }
        [Test]
        public void Power_NegativeDecimalNumbers_ResultIsCorrect()
        {
            var x = _uut.Power(-37, -3);
            Assert.That(x, Is.EqualTo(Math.Pow(-37,-3)).Within(0.01));
        }

        [Test]
        public void Power_NegativeExponent_ThrowException()
        {
            Assert.That(() => _uut.Power(0,-5), Throws.TypeOf<ArgumentException>());
        }

        // Only one parameter
        [TestCase(2, 2)]
        [TestCase(-2, -2)]
        [TestCase(2.2, 2.2)]
        public void Addition_AdditionNumbers_ResultIsCorrect(double a, double result)
        {
            Assert.That(_uut.Addition(a), Is.EqualTo(result));
        }

        [TestCase(2, 4)]
        [TestCase(-2, 0)]
        [TestCase(2.2, 4.2)]
        public void Addition_AdditionNumber_AccEqualsTwo_ResultIsCorrect(double a, double result)
        {
            _uut.Addition(2);
            Assert.That(_uut.Addition(a), Is.EqualTo(result));
        }

        [Test]
        public void Clear_ClearAccumulator()
        {
            _uut.Addition(5);
            _uut.Clear();
            Assert.AreEqual(_uut.Accumulator, 0);
        }

        [TestCase(2, -2)]
        [TestCase(-2, 2)]
        [TestCase(-6.6, 6.6)]
        public void Subtraction_SubtractionNumbers_ResultIsCorrect(double a, double result)
        {
            Assert.That(_uut.Subtraction(a), Is.EqualTo(result));
        }

        [TestCase(2, 0)]
        [TestCase(-2, 4)]
        [TestCase(-6.6, 8.6)]
        public void Subtraction_SubtractionNumbers_AccEqualsTwo_ResultIsCorrect(double a, double result)
        {
            _uut.Addition(2);
            Assert.That(_uut.Subtraction(a), Is.EqualTo(result));
        }


        [TestCase(2, 0)]
        [TestCase(-2, 0)]
        [TestCase(2.2, 0)]
        public void Multiplication_MultiplicationNumbers_ResultIsCorrect(double a, double result)
        {
            Assert.That(_uut.Multiplication(a), Is.EqualTo(result).Within(0.001));
        }
        [TestCase(2, 4)]
        [TestCase(-2, -4)]
        [TestCase(2.2, 4.4)]
        public void Multiplication_MultiplicationNumbers_AccEqualsTwo_ResultIsCorrect(double a, double result)
        {
            _uut.Addition(2);
            Assert.That(_uut.Multiplication(a), Is.EqualTo(result).Within(0.001));
        }

        [TestCase(2, 0)]
        [TestCase(-3, 0)]
        [TestCase(5.5, 0)]
        public void Division_DivideNumber_ResultIsCorrect(double a, double result)
        {
            Assert.That(_uut.Division(a), Is.EqualTo(result).Within(0.001));
        }

        [TestCase(2, 1)]
        [TestCase(-3, -0.667)]
        [TestCase(5.5, 0.3636)]
        public void Division_DivideNumber_AccEqualsTwo_ResultIsCorrect(double a, double result)
        {
            _uut.Addition(2); // We start by adding by two. 
            Assert.That(_uut.Division(a), Is.EqualTo(result).Within(0.001));
        }

        [Test]
        public void Division_DivideByZero_ThrowException()
        {
            Assert.That(() => _uut.Division(0), Throws.TypeOf<DivideByZeroException>());
        }

        [TestCase(2, 0)]
        [TestCase(0.1, 0)]
        [TestCase(0, 1)]
        public void Power_PowerNumbers_ResultIsCorrect(double a, double result)
        {
            Assert.That(_uut.Power(a), Is.EqualTo(result).Within(0.001));
        }

        [Test]
        public void Power_NegativeExponent_AccEqualsZero_ThrowException()
        {
            Assert.That(() => _uut.Power(-5), Throws.TypeOf<ArgumentException>());
        }


        [TestCase(2, 4)]
        [TestCase(-5, 0.03125)]
        [TestCase(0.1, 1.0718)]
        public void Power_PowerNumbers_AccEqualsTwo_ResultIsCorrect(double a, double result)
        {
            _uut.Addition(2);
            Assert.That(_uut.Power(a), Is.EqualTo(result).Within(0.001));
        }

        [TestCase(2, 64)]
        [TestCase(-5, -0.000031)]
        [TestCase(0, 1)]
        public void Power_PowerNumbers_AccEqualsMinusEight_ResultIsCorrect(double a, double result)
        {
            _uut.Addition(-8);
            Assert.That(_uut.Power(a), Is.EqualTo(result).Within(0.001));
        }

    }
}
