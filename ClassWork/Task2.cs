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
            Tuple<double, string, string> tuple = AskUserForInput();
            PrintResult(CalculateCurrency(tuple.Item1, tuple.Item2, tuple.Item3));
        }

        private static double CalculateCurrency(double amountOfMoney, string currency, string operation)
        {
            if (operation.ToUpper() == "BUY")
            {
                switch (currency.ToUpper())
                {
                    case "USD":
                        return amountOfMoney * 26.8;
                    case "EUR":
                        return amountOfMoney * 30;
                    default:
                        return 0;
                }
            }
            else
            {
                switch (currency.ToUpper())
                {
                    case "USD":
                        return amountOfMoney / 27.2;
                    case "EUR":
                        return amountOfMoney / 30.6;
                    default:
                        return 0;
                }
            }
        }

        private static Tuple<double, string, string> AskUserForInput()
        {
            double amountOfMoney = 0;
            string currency = null;
            string operation = null;
            bool isCurrencyValid = false;
            bool isAmountOfMoneyValid = false;
            bool isOperationValid = false;
            while (!isOperationValid)
            {
                Console.Write("Enter operation (BUY, SALE): ");
                operation = Console.ReadLine();
                isOperationValid = ValidateOperationInput(operation);
            }
            while (!isCurrencyValid)
            {
                Console.Write("Enter currency (EUR, USD): ");
                currency = Console.ReadLine();
                isCurrencyValid = ValidateCurrencyInput(currency);
            }
            while (!isAmountOfMoneyValid)
            {
                Console.Write("Enter amount of money: ");
                isAmountOfMoneyValid = double.TryParse(Console.ReadLine(), out amountOfMoney);
            }

            return Tuple.Create(amountOfMoney, currency, operation);
        }

        private static bool ValidateCurrencyInput(string currency)
        {
            currency = currency.ToUpper();
            if (currency != "USD" && currency != "EUR")
                return false;
            else
                return true;
        }

        private static bool ValidateOperationInput(string operation)
        {
            operation = operation.ToUpper();
            if (operation != "BUY" && operation != "SALE")
                return false;
            else
                return true;
        }

        private static void PrintResult(double result)
        {
            Console.WriteLine($"Result: {result}");
        }
    }
}
