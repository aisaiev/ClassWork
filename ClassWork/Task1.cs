using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    public static class Task1
    {
        public static void Calculate()
        {
            Tuple<double, double, char> userInput =  AskUserForInput();
            PrintResult(PerformMathCalcualtion(userInput.Item1, userInput.Item2, userInput.Item3));
        }

        private static Tuple<double, double, char> AskUserForInput()
        {
            double firstNumber = 0;
            double secondNumber = 0;
            char operation = ' ';
            bool isFirstNumberValid = false;
            bool isSecondNumberValid = false;
            bool isOperationValid = false;
            while (!isFirstNumberValid)
            {
                Console.Write("Enter the first number: ");
                isFirstNumberValid = double.TryParse(Console.ReadLine(), out firstNumber);
            }
            while (!isSecondNumberValid)
            {
                Console.Write("Enter the first number: ");
                isSecondNumberValid = double.TryParse(Console.ReadLine(), out secondNumber);
            }
            while (!isOperationValid)
            {
                Console.Write("Enter operation [+ - * /]: ");
                string sign = Console.ReadLine();
                switch (sign[0])
                {
                    case '+':
                        operation = '+';
                        isOperationValid = true;
                        break;
                    case '-':
                        operation = '-';
                        isOperationValid = true;
                        break;
                    case '*':
                        operation = '*';
                        isOperationValid = true;
                        break;
                    case '/':
                        operation = '/';
                        isOperationValid = true;
                        break;
                    default:
                        Console.WriteLine("Plese enter valid math operation!");
                        isOperationValid = false;
                        break;
                }
            }

            return Tuple.Create(firstNumber, secondNumber, operation);
        }

        private static double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        private static double Sub(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        private static double Mul(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        private static double Div(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }

        private static double PerformMathCalcualtion(double firstNumber, double secondNumber, char mathOperation)
        {
            double result = 0;
            switch (mathOperation)
            {
                case '+':
                    result = Add(firstNumber, secondNumber);
                    break;
                case '-':
                    result = Sub(firstNumber, secondNumber);
                    break;
                case '*':
                    result = Mul(firstNumber, secondNumber);
                    break;
                case '/':
                    result = Div(firstNumber, secondNumber);
                    break;
            }
            return result;
        }

        private static void PrintResult(double result)
        {
            Console.WriteLine($"Result of the operation: {result}");
        }
    }
}
