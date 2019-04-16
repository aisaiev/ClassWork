﻿using System;
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

        private static int[] MyReverse(int[] array)
        {
            int[] reversedArray = new int[array.Length];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                reversedArray[array.Length - 1 - i] = array[i];
            }
            return reversedArray;
        }

        private static int[] SubArray(int[] array, int index, int count)
        {
            int[] resultArray = new int[count];
            if (index == 0 && count > array.Length)
            {
                for (int i = index; i < count; i++)
                {
                    if (i >= array.Length)
                    {
                        resultArray[i] = 1;
                    }
                    else
                    {
                        resultArray[i] = array[i];
                    }
                }
            }
            else
            {
                for (int i = index; i < count + index; i++)
                {
                    if (i >= array.Count())
                    {
                        resultArray[i - index] = 1;
                    }
                    else
                    {
                        resultArray[i - index] = array[i];
                    }
                }
            }
            return resultArray;
        }

        private static int[] IncreasingLengthOfArrayOfOne(int[] array)
        {
            int[] resultArray = new int[array.Length + 1];
            Array.Copy(array, resultArray, array.Length);
            return resultArray;
        }

        private static int[] CopyArray(int[] array, int value)
        {
            int[] resultArray = new int[array.Length + 1];
            Array.Copy(array, 0, resultArray, 1, array.Length);
            resultArray[0] = value;
            return resultArray;
        }

        private static void Task8()
        {
            int[,] array = FillTwoDimensinalArrayByRandomNumbers(2, 5, 1, 11);
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == number)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine($"Amount of number {number} in array is {counter}");
        }

        static int[,] FillTwoDimensinalArrayByRandomNumbers(int rowCount, int columnCount, int randomMinValue, int randomMaxValue)
        {
            int[,] array = new int[rowCount, columnCount];
            Random rnd = new Random();

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    array[i, j] = rnd.Next(randomMinValue, randomMaxValue + 1);
                }
            }
            return array;
        }

        private static void Task9()
        {
            Console.Write("Enter index move from: ");
            int fromIndex = int.Parse(Console.ReadLine());
            Console.Write("Enter index move to: ");
            int toIndex = int.Parse(Console.ReadLine());
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Initial array");
            PrintTwoDimensionalArray(array);
            for (int i = 0; i < array.GetLength(1); i++)
            {
                int tempValue = array[fromIndex, i];
                array[fromIndex, i] = array[toIndex, i];
                array[toIndex, i] = tempValue;
            }
            Console.WriteLine("Result array");
            PrintTwoDimensionalArray(array);
        }

        static void PrintTwoDimensionalArray(int[,] arrayForPrint)
        {
            for (int i = 0; i < arrayForPrint.GetLength(0); i++)
            {
                for (int j = 0; j < arrayForPrint.GetLength(1); j++)
                {
                    Console.Write("{0}\t", arrayForPrint[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void Task10()
        {
            Console.Write("Enter column index to calculate sum of elements: ");
            int columnIndex = int.Parse(Console.ReadLine());
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[i, columnIndex];
            }
            Console.WriteLine($"Sum of elements in column {columnIndex} is {sum}");
        }
    }
}
