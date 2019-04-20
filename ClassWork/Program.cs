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

        private static void Task5(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    if (str[i + 1] == ' ')
                        str = str.Remove(i + 1, 1);
            }
            Console.WriteLine(str); ;
        }

        private static void Task6(string str, int position)
        {
            string[] strArray = str.Split(' ');
            Console.WriteLine(strArray[position - 1][0]);
        }

        private static void Task7(string str)
        {
            string[] strArray = str.Split(' ');
            for (int i = strArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(strArray[i]);
            }
        }

        private static void Task8(string str)
        {
            string[] strArray = str.Split(' ');
            int maxWordLength = 0;
            int minWordLength = int.MaxValue;
            foreach (var item in strArray)
            {
                if (item.Length > maxWordLength)
                    maxWordLength = item.Length;
                if (item.Length < minWordLength)
                    minWordLength = item.Length;
            }
            Console.WriteLine($"Max word length: {maxWordLength}");
            Console.WriteLine($"Min word length: {minWordLength}");
        }

        private static void Task1()
        {
            string str = "hello world qwerty";
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i; j < str.Length; j++)
                {
                    if (j != str.Length - 1)
                    {
                        if (str[i] == str[j + 1])
                        {
                            str = str.Remove(j + 1, 1);
                        }
                    }
                }
            }
            Console.WriteLine(str);
        }
    }
}
