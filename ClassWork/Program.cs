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
            Console.Write("Enter size of array: ");
            int size = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] arrayNumber = new int[size];
            for (int i = 0; i < size; i++)
            {
                arrayNumber[i] = rnd.Next(0, 11);
            }
            PrintArrayOfNumbers(arrayNumber);
            Console.WriteLine($"Max number: {FindMaximumNumberInArray(arrayNumber)}");
            Console.WriteLine($"Min number: {FindMinimumNumberInArray(arrayNumber)}");
            Console.WriteLine($"Sum numbers of array: {CalculateSumOfElemInArray(arrayNumber)}");
            Console.WriteLine($"Average number of array: {CalculateAverageNumberInArray(arrayNumber)}");
            PrintOddNumbersOfArray(arrayNumber);
        }

        private static int FindMaximumNumberInArray(int[] array)
        {
            int maxNumber = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxNumber)
                {
                    maxNumber = array[i];
                }
            }
            return maxNumber;
        }

        private static int FindMinimumNumberInArray(int[] array)
        {
            int minNumber = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minNumber)
                {
                    minNumber = array[i];
                }
            }
            return minNumber;
        }

        private static int CalculateSumOfElemInArray(int[] array)
        {
            int sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }
            return sum;
        }

        private static double CalculateAverageNumberInArray(int[] array)
        {
            double sum = CalculateSumOfElemInArray(array);
            return sum / array.Length;
        }

        private static void PrintOddNumbersOfArray(int[] array)
        {
            Console.Write("Odd numbers: ");
            foreach (var item in array)
            {
                if (item % 2 != 0)
                {
                    Console.Write(item);
                    Console.Write(" ");
                }
            }
        }

        private static void PrintArrayOfNumbers(int[] array)
        {
            Console.WriteLine($"Array: {string.Join(",", array)}");
        }

        private static void Task2()
        {
            int[] array = new int[5];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 11);
            }
            PrintArrayOfNumbers(array);

            int[] tempArr = array;
            Array.Sort(tempArr);

            List<int> dublicateValuesList = new List<int>();
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (tempArr[i + 1] == array[i])
                {
                    dublicateValuesList.Add(tempArr[i]);
                }
            }

            List<int> arrayList = array.ToList();
            foreach (var item in dublicateValuesList)
            {
                int index = Array.IndexOf(array, item);
                arrayList.RemoveAt(index);
            }

            int[] resultArr = arrayList.ToArray();

            PrintArrayOfNumbers(resultArr);
        }

        private static void Task3(int arraySize)
        {
            Console.Write("Enter min index: ");
            int minIndex = int.Parse(Console.ReadLine());
            Console.Write("Enter max index: ");
            int maxIndex = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int[] array = new int[arraySize];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 11);
            }
            PrintArrayOfNumbers(array);

            for (int i = 0; i < array.Length; i++)
            {
                if (i > minIndex && i < maxIndex)
                {
                    Console.WriteLine($"Index: {i} Value: {array[i]}");
                }
            }
        }

        private static void Task4(int arraySize)
        {
            int[] array = new int[arraySize];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 11);
            }
            PrintArrayOfNumbers(array);
            double averageNUmber = CalculateAverageNumberInArray(array);
            Console.WriteLine($"Average: {averageNUmber}");
            foreach (var item in array)
            {
                if (item > averageNUmber)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
