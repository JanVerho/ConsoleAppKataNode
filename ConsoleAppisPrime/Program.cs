using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppisPrime
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            const int maxInt = 2555;// 2147483647;
            Console.WriteLine(IsPrimeGetal(maxInt));
        }

        public static bool IsPrimeGetal(int getal)
        {
            if (getal < 2) return false;
            bool isPrime = true;
            for (int i = 2; i < getal; i++)
            {
                if (getal % i == 0)
                {
                    isPrime = false;
                }

                if (getal / i < i)
                {
                    return isPrime;
                }
            }

            return isPrime;
        }
    }
}