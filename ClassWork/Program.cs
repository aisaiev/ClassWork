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

        private static int Task2(string lineString, char symbol)
        {
            int count = 0;
            for (int i = 0; i < lineString.Length; i++)
            {
                if (lineString[i] == symbol)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
