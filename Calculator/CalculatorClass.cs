using System;

namespace Calculator
{
    public class CalculatorClass
    {
        public double Sum(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public double Subtract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public double Multiply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public double Divide(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return firstNumber / secondNumber;
        }

        public double Power(double firstNumber, double secondNumber)
        {
            if (secondNumber % 1 != 0)
            {
                throw new ArgumentException("Exponent must be an integer.");
            }
            return Math.Pow(firstNumber, secondNumber);
        }
    }
}