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

        private static string Task3(string initialString, string stringToInsert, int index)
        {
            return initialString.Insert(index, stringToInsert);
        }

        private static void Task4(string str)
        {
            int questionMarkCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '?')
                    questionMarkCount++;
                if (questionMarkCount == 1)
                    if (str[i] == ' ')
                        str = str.Remove(i, 1);
                if (questionMarkCount == 2)
                    break;
            }
            Console.WriteLine(str);
        }
    }
}
