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
    }
}
