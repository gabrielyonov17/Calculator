using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTestsCalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIfSumWorksProperlyWithPositiveNumbers()
        {
            // Arrange
            double firstNumber = 4;
            double secondNumber = 2.5;
            CalculatorClass myCalc = new CalculatorClass();

            // Act
            double result = myCalc.Sum(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(6.5, result, "4 + 2.5 != 6.5");
        }
        [TestMethod]
        public void TestIfSumWorksProperlyWithNegativeNumbers()
        {
            // Arrange
            double firstNumber = -4;
            double secondNumber = -1.5;
            CalculatorClass myCalc = new CalculatorClass();

            // Act
            double result = myCalc.Sum(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(-5.5, result, "-4 + (-1.5) != -5.5");
        }

        [TestMethod]
        public void TestIfSumWorksProperlyWithZeroNumbers()
        {
            // Arrange
            double firstNumber = 8;
            double secondNumber = 0;
            CalculatorClass myCalc = new CalculatorClass();

            // Act
            double result = myCalc.Sum(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(8, result, "8 + 0 != 8");
        }

        [TestMethod]
        public void TestIfSubtractWorksProperlyWithPositiveNumbers()
        {
            // Arrange
            double firstNumber = 9;
            double secondNumber = 0.75;
            CalculatorClass myCalc = new CalculatorClass();

            // Act
            double result = myCalc.Subtract(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(8.25, result, "9 - 0.75 != 8.25");
        }
        [TestMethod]
        public void TestIfSubtractWorksProperlyWithNegativeNumbers()
        {
            // Arrange
            double firstNumber = -6;
            double secondNumber = -10;
            CalculatorClass myCalc = new CalculatorClass();

            // Act
            double result = myCalc.Subtract(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(4, result, "-6 - (-10) != 4");
        }

        [TestMethod]
        public void TestIfSubtractWorksProperlyWithZeroNumbers()
        {
            // Arrange
            double firstNumber = 7;
            double secondNumber = 0;
            CalculatorClass myCalc = new CalculatorClass();

            // Act
            double result = myCalc.Subtract(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(7, result, "7 - 0 != 7");
        }

        [TestMethod]
        public void TestIfMultiplyWorksProperlyWithPositiveNumbers()
        {
            // Arrange
            double firstNumber = 2;
            double secondNumber = 1.75;
            CalculatorClass myCalc = new CalculatorClass();

            // Act
            double result = myCalc.Multiply(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(3.5, result, "2 * 1.75 != 3.5");
        }
        [TestMethod]
        public void TestIfMultiplyWorksProperlyWithNegativeNumbers()
        {
            // Arrange
            double firstNumber = -6;
            double secondNumber = -5.5;
            CalculatorClass myCalc = new CalculatorClass();

            // Act
            double result = myCalc.Multiply(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(33, result, "-6 * (-5.5) != 33");
        }

        [TestMethod]
        public void TestIfMultiplyWorksProperlyWithZeroNumbers()
        {
            // Arrange
            double firstNumber = 1;
            double secondNumber = 0;
            CalculatorClass myCalc = new CalculatorClass();

            // Act
            double result = myCalc.Multiply(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(0, result, "1 * 0 != 0");
        }

        [TestMethod]
        public void TestIfDivideWorksProperlyWithPositiveNumbers()
        {
            // Arrange
            double firstNumber = 225;
            double secondNumber = 25;
            CalculatorClass myCalc = new CalculatorClass();

            // Act
            double result = myCalc.Divide(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(9, result, "225 / 25 != 9");
        }
        [TestMethod]
        public void TestIfDivideWorksProperlyWithNegativeNumbers()
        {
            // Arrange
            double firstNumber = -9;
            double secondNumber = -1.5;
            CalculatorClass myCalc = new CalculatorClass();

            // Act
            double result = myCalc.Divide(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(6, result, "-9 / (-1.5) != 6");
        }

        [TestMethod]
        public void TestIfDivideWorksProperlyWithZeroNumbers()
        {
            // Arrange
            double firstNumber = 0;
            double secondNumber = 53;
            CalculatorClass myCalc = new CalculatorClass();

            // Act
            double result = myCalc.Divide(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(0, result, "0 / 53 != 0");
        }
    }
}
