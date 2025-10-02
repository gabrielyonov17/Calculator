using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            CalculatorClass myCalc = new CalculatorClass();

            double result = myCalc.Sum(firstNumber, secondNumber);
            Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");

            result = myCalc.Subtract(firstNumber, secondNumber);
            Console.WriteLine($"{firstNumber} - {secondNumber} = {result}");

            result = myCalc.Multiply(firstNumber, secondNumber);
            Console.WriteLine($"{firstNumber} * {secondNumber} = {result}");
            try
            {
                result = myCalc.Divide(firstNumber, secondNumber);
                Console.WriteLine($"{firstNumber} / {secondNumber} = {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
