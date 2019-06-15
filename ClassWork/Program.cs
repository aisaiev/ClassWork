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
            Task1();
        }

        static void Task1()
        {
            DateTime dateTimeNow = DateTime.Now;
            Console.WriteLine(dateTimeNow.ToString("MM/dd/yyyy"));

            DateTime yesterdayDay = DateTime.Now.AddDays(-1);
            Console.WriteLine(yesterdayDay.ToString("MM/dd/yyyy"));

            DateTime twoMonthBefore = DateTime.Now.AddMonths(-2);
            Console.WriteLine(twoMonthBefore.ToString("MM/dd/yyyy"));

            DateTime oneYearBefore = DateTime.Now.AddYears(-1);
            Console.WriteLine(oneYearBefore.ToString("MM/dd/yyyy"));

            DateTime birthDay = new DateTime(1991, 07, 06);
            Console.WriteLine(birthDay.ToString("MM/dd/yyyy"));
        }
    }
}
