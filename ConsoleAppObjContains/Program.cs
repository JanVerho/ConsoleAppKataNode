using System;
using System.Linq;

namespace ConsoleAppObjContains
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Kata.Check(new object[] { 66, 101 }, 66));
        }
    }

    public class Kata
    {
        public static bool Check(object[] a, object x)
        {
            return a.Contains(x);
        }
    }
}