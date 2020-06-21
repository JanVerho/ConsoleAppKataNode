using System;
using System.Reflection;

namespace ConsoleAppKataPower
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // Console.WriteLine(Program.ModifiedSum(new int[] { 1, 2 }, 5));

            Console.WriteLine(Program.solve(10));
        }

        public static int ModifiedSum(int[] a, int n)
        {
            double powSum = 0.00;
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                powSum += (Math.Pow((double)(a[i]), (double)(n)));
                sum += a[i];
            }
            Console.WriteLine(powSum + " - " + sum);
            return (Convert.ToInt32(powSum) - sum);
        }

        public static long solve(long n)
        {
            double power = 0.00;
            bool restultOk = false;

            int i = 0;
            while (!restultOk)
            {
                i++;
                power = Math.Pow(i, 2);
                if (Math.Sqrt((double)(power + n)) == ((int)Math.Sqrt((double)(power + n))))
                {
                    restultOk = true;
                }
                if (power > Math.Pow((double)n, 2.00))
                {
                    return -1;
                }
            }
            return (long)(power);
        }
    }
}