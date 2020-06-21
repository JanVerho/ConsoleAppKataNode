using System;
using System.Linq;

namespace ConsoleAppSumArray
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(ArrayPlusArray(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }));
        }

        public static int ArrayPlusArray(int[] arr1, int[] arr2)
        {
            return arr1.Sum() + arr2.Sum();
        }
    }
}