using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    public static class Task2
    {
        private static List<Currency> currencies;
        private static Currency baseCurrency;
        public static void PerfromCurrencyConvertation()
        {
            DownloadCurrencyExchange().Wait();
            Tuple<double, string, string> tuple = AskUserForInput();
            PrintResult(CalculateCurrencyExchange(tuple.Item1, tuple.Item2, tuple.Item3));
        }

        public static async Task DownloadCurrencyExchange()
        {
            string url = $"https://api.privatbank.ua/p24api/pubinfo?json&exchange&coursid=5";

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(url);
                string stringResponse = await response.Content.ReadAsStringAsync();
                currencies = JsonConvert.DeserializeObject<List<Currency>>(stringResponse);
            }
        }

        private static double CalculateCurrencyExchange(double amountOfMoney, string currency, string operation)
        {
            if (operation.ToUpper() == "BUY")
            {
                switch (currency.ToUpper())
                {
                    case "USD":
                        baseCurrency = currencies.Find(x => x.Ccy == "USD");
                        return amountOfMoney * double.Parse(baseCurrency.Buy);
                    case "EUR":
                        baseCurrency = currencies.Find(x => x.Ccy == "EUR");
                        return amountOfMoney * double.Parse(baseCurrency.Buy);
                    default:
                        return 0;
                }
            }
            else
            {
                switch (currency.ToUpper())
                {
                    case "USD":
                        baseCurrency = currencies.Find(x => x.Ccy == "USD");
                        return amountOfMoney / double.Parse(baseCurrency.Sale);
                    case "EUR":
                        baseCurrency = currencies.Find(x => x.Ccy == "EUR");
                        return amountOfMoney / double.Parse(baseCurrency.Sale);
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
