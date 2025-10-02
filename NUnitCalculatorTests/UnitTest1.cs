using Calculator;
using NUnit.Framework;
using System;

namespace NUnitCalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private CalculatorClass calc;

        [SetUp]
        public void Setup()
        {
            calc = new CalculatorClass();
        }

        [TestCase(4, 2)]
        [TestCase(-4, -1)]
        [TestCase(8, 0)]
        public void TestSum(double firstNumber, double secondNumber)
        {
            Assert.AreEqual(firstNumber + secondNumber, calc.Sum(firstNumber, secondNumber));
        }

        [TestCase(9, 2)]
        [TestCase(-6, -10)]
        [TestCase(7, 0)]
        public void TestSubtract(double firstNumber, double secondNumber)
        {
            Assert.AreEqual(firstNumber - secondNumber, calc.Subtract(firstNumber, secondNumber));
        }

        [TestCase(2, 2)]
        [TestCase(-6, -5)]
        [TestCase(1, 0)]
        [TestCase(-3, 2)]
        public void TestMultiply(double firstNumber, double secondNumber)
        {
            Assert.AreEqual(firstNumber * secondNumber, calc.Multiply(firstNumber, secondNumber));
        }

        [TestCase(20, 5)]
        [TestCase(-10, -2)]
        [TestCase(0, 10)]
        [TestCase(12, -3)]
        public void TestDivide(double firstNumber, double secondNumber)
        {
            Assert.AreEqual(firstNumber / secondNumber, calc.Divide(firstNumber, secondNumber));
        }

        [TestCase(10, 0)]
        [TestCase(-5, 0)]
        [TestCase(0, 0)]
        public void TestDivideByZero(double firstNumber, double secondNumber)
        {
            Assert.Throws<DivideByZeroException>(() => calc.Divide(firstNumber, secondNumber));
        }

        [TestCase(2, 3, 8)]
        [TestCase(5, 0, 1)]
        [TestCase(10, 1, 10)]
        [TestCase(3, 2, 9)]
        public void TestPowerValidIntegerExponents(double firstNumber, double secondNumber, double expected)
        {
            Assert.That(calc.Power(firstNumber, secondNumber), Is.EqualTo(expected));
        }

        [TestCase(2, 2.5)]
        [TestCase(5, 1.1)]
        [TestCase(10, -3.5)]
        public void TestPowerInvalidExponentThrows(double firstNumber, double secondNumber)
        {
            Assert.That(() => calc.Power(firstNumber, secondNumber),
                        Throws.TypeOf<ArgumentException>());
        }
    }
}
