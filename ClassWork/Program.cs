using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void Task1()
        {
            Console.Write("Enter the first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            bool isOperationValid = false;

            while (!isOperationValid)
            {
                Console.Write("Enter operation [+ - * /]: ");
                string sign = Console.ReadLine();
                switch (sign)
                {
                    case "+":
                        Add(firstNumber, secondNumber);
                        isOperationValid = true;
                        break;
                    case "-":
                        Sub(firstNumber, secondNumber);
                        isOperationValid = true;
                        break;
                    case "*":
                        Mul(firstNumber, secondNumber);
                        isOperationValid = true;
                        break;
                    case "/":
                        Div(firstNumber, secondNumber);
                        isOperationValid = true;
                        break;
                    default:
                        Console.WriteLine("Plese enter valid math operation!");
                        isOperationValid = false;
                        break;
                }
            }
        }

        private static void Add(double firstNumber, double secondNumber)
        {
            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
        }

        private static void Sub(double firstNumber, double secondNumber)
        {
            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
        }

        private static void Mul(double firstNumber, double secondNumber)
        {
            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
        }

        private static void Div(double firstNumber, double secondNumber)
        {
            if (secondNumber != 0)
            {
                Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
            }
            else
            {
                Console.WriteLine("Error: divide by zero operation");
            }
        }
    }
}
