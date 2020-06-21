using System;

namespace ConsoleAppSquare
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Kata.IsSquare(-1) + " -1 is Not a square number");
            Console.WriteLine(Kata.IsSquare(3) + " 3 is Not a square number");
            Console.WriteLine(Kata.IsSquare(4) + " 4 is a square number");
            Console.WriteLine(Kata.IsSquare(25) + " 25 is a square number");
            Console.WriteLine(Kata.IsSquare(26) + " 26 isn't a square number");
        }

        public class Kata
        {
            public static bool IsSquare(int n)
            {
                //Sqrt floor to int
                int sqrtIntRes = (int)Math.Floor(Math.Sqrt(n));
                if (n < 0) return false;
                else
                {
                    if (n == (sqrtIntRes * sqrtIntRes)) return true;
                    else return false;
                }
            }
        }
    }
}