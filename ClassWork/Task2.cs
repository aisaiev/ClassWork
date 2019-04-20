using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    public static class Task2
    {
        public static void PerfromCurrencyConvertation()
        {
            Tuple<double, string> tuple = AskUserForInput();
            PrintResult(CalculateCurrency(tuple.Item1, tuple.Item2));
        }

        private static double CalculateCurrency(double amountOfMoney, string currency)
        {
            switch (currency)
            {
                case "USD":
                    return amountOfMoney * 26;
                case "EUR":
                    return amountOfMoney * 30;
                default:
                    return 0;
            }
        }

        private static Tuple<double, string> AskUserForInput()
        {
            double amountOfMoney = 0;
            string currency = null;
            bool isCurrencyValid = false;
            bool isAmountOfMoneyValid = false;
            while (!isAmountOfMoneyValid)
            {
                Console.Write("Enter amount of money: ");
                isAmountOfMoneyValid = double.TryParse(Console.ReadLine(), out amountOfMoney);
            }
            while (!isCurrencyValid)
            {
                Console.Write("Enter currency (EUR, USD): ");
                currency = Console.ReadLine();
                isCurrencyValid = ValidateCurrencyInput(currency);
            }

            return Tuple.Create(amountOfMoney, currency);
        }

        private static bool ValidateCurrencyInput(string currency)
        {
            if (currency.ToUpper() != "USD" || currency.ToUpper() != "EUR")
                return true;
            else
                return false;
        }

        private static void PrintResult(double result)
        {
            Console.WriteLine($"Result: {result}");
        }
    }
}
