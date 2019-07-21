using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_13_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Currency currency = new Currency();
            Task.Run(async () => { await currency.GetCurrenciesAsync(); }).Wait();
        }
    }
}
