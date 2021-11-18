using System;
using System.Collections.Generic;

namespace GenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
            ToPrint<int>(intArray);
            ToPrint<double>(doubleArray);
            ToPrint<char>(charArray);
        }
        public static void ToPrint<T>(T[] inputArray)
        {
            foreach(var element in inputArray)
            {
                Console.WriteLine(element);
            }
        }
    }
}