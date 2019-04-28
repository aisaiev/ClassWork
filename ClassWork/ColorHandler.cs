using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class ColorHandler
    {
        public static void Print(string stroka, int color)
        {
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(stroka);
        }
    }

    public enum Color
    {
        White = 15,
        Red = 12,
        Green = 10
    }
}
