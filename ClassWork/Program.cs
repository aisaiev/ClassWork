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
            int seconds = int.Parse(Console.ReadLine());
            int hours = seconds / 3600;
            Console.WriteLine($"Hours: {hours}");
        }

        private static void Task2()
        {
            Console.Write("Enter number A: ");
            int numberA = int.Parse(Console.ReadLine());
            Console.Write("Enter number B: ");
            int numberB = int.Parse(Console.ReadLine());
            Console.Write("Enter number C: ");
            int numberC = int.Parse(Console.ReadLine());

            if (numberA < numberB && numberB < numberC)
            {
                Console.WriteLine($"{numberB} between number {numberA} and number {numberC}");
            }
            else
            {
                Console.WriteLine($"{numberB} is not between number {numberA} and number {numberC}");
            }
        }

        private static void Task3()
        {
            int numberOfDigits = 0;
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            int tempNumber = number;
            while (tempNumber != 0)
            {
                tempNumber /= 10;
                numberOfDigits++;
            }
            if (numberOfDigits == 3)
            {
                Console.WriteLine($"Number {number} contains 3 digits");
            }
        }

        private static void Task4()
        {
            int x= 10;
            int y= 12;
            int z= 3;

            Console.WriteLine($"x=10, y=12, z=3 \nOperation: x += y - x++ * z \nx={x += y - x++ * z}");
            Console.WriteLine($"x=10, y=12, z=3 \nOperation: z = --x - y * 5 \nz={--x - y * 5}");
            Console.WriteLine($"x=10, y=12, z=3 \nOperation: y /= x + 5 % z \ny={y /= x + 5 % z}");
            Console.WriteLine($"x=10, y=12, z=3 \nOperation: z = x++ + y * 5 \nz={x++ + y * 5}");
            Console.WriteLine($"x=10, y=12, z=3 \nOperation: x = y - x++ * z \nx={y - x++ * z}");
        }

        private static void Task5()
        {
            Console.Write("Enter the first number: ");
            double operand1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double operand2 = double.Parse(Console.ReadLine());
            bool isOperationValid = false;

            while (!isOperationValid)
            {
                Console.Write("Enter operation [+ - * /]: ");
                string sign = Console.ReadLine();
                switch (sign)
                {
                    case "+":
                        Console.WriteLine($"{operand1} + {operand2} = {operand1 + operand2}");
                        isOperationValid = true;
                        break;
                    case "-":
                        Console.WriteLine($"{operand1} - {operand2} = {operand1 - operand2}");
                        isOperationValid = true;
                        break;
                    case "*":
                        Console.WriteLine($"{operand1} * {operand2} = {operand1 * operand2}");
                        isOperationValid = true;
                        break;
                    case "/" when operand2 != 0:
                        Console.WriteLine($"{operand1} / {operand2} = {operand1 / operand2}");
                        isOperationValid = true;
                        break;
                    default:
                        Console.WriteLine("Divide by zero or plese enter valid math operation!");
                        isOperationValid = false;
                        break;
                }
            }
        }

        private static void Task6()
        {
            Console.Write("Enter number from 0 till 100:");
            int number = int.Parse(Console.ReadLine());
            if (number >= 0 && number <= 14)
            {
                Console.WriteLine($"Number {number} in [0-14] range");
            }
            if (number >= 15 && number <=35)
            {
                Console.WriteLine($"Number {number} in [15-35] range");
            }
            if (number >= 35 && number <= 50)
            {
                Console.WriteLine($"Number {number} in [35-50] range");
            }
            if (number >= 50 && number <= 100)
            {
                Console.WriteLine($"Number {number} in [50-100] range");
            }
            else
            {
                Console.WriteLine($"Number {number} is not in [0-100] range");
            }
        }
    }
}
