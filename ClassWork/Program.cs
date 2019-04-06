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
            Task9();
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

        private static void Task7()
        {
            Dictionary<string, string> weatherConditionsVocabulary = new Dictionary<string, string>
            {
                { "дождь", "rain" },
                { "снег", "snow" },
                { "облачно", "cloudy" },
                { "ветренно", "windy" },
                { "жарко", "hot" },
                { "тепло", "warm" },
                { "холодно", "cool" },
                { "прогноз", "forecast" },
                { "thunder", "гром" },
                { "ураган", "hurricane" }
            };

            Console.Write("Enter weather condition on RUS: ");
            string rusWeatherCondtition = Console.ReadLine().ToLower();
            if (weatherConditionsVocabulary.TryGetValue(rusWeatherCondtition, out string engWeatherCondtition))
            {
                Console.WriteLine($"{rusWeatherCondtition} : {engWeatherCondtition}");
            }
            else
            {
                Console.WriteLine("Weather condition isn't found in vocabulary");
            }
        }

        private static void Task8()
        {
            Console.Write("Enter long and meritorious service in years: ");
            int years = int.Parse(Console.ReadLine());
            Console.Write("Enter sallary to calculate bounty: ");
            int sallary = int.Parse(Console.ReadLine());

            if (years < 5)
            {
                Console.WriteLine($"Bounty is: {sallary * 0.1}");
            }
            if (years >=5 && years < 10)
            {
                Console.WriteLine($"Bounty is: {sallary * 0.15}");
            }
            if (years >= 10 && years < 15)
            {
                Console.WriteLine($"Bounty is: {sallary * 0.25}");
            }
            if (years >= 15 && years < 20)
            {
                Console.WriteLine($"Bounty is: {sallary * 0.35}");
            }
            if (years >= 20 && years < 25)
            {
                Console.WriteLine($"Bounty is: {sallary * 0.45}");
            }
            if (years >= 25)
            {
                Console.WriteLine($"Bounty is: {sallary * 0.5}");
            }
        }

        private static void Task9()
        {
            bool isNewAttempt = false;
            do
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

                Console.Write("Do you want to try again y/n: ");
                string result = Console.ReadLine();
                switch (result)
                {
                    case "y":
                        isNewAttempt = true;
                        break;
                    case "n":
                        isNewAttempt = false;
                        break;
                }
            } while (isNewAttempt);
        }
    }
}
