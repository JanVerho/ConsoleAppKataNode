using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppUniqueInList
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            foreach (var item in Program.UniqueInOrder("Hello World!"))
            {
                Console.WriteLine(item);
            }

            foreach (var item in Program.UniqueInOrder("AAAABBBCCDAABBB"))
            {
                Console.WriteLine(item);
            }

            foreach (var item in Program.UniqueInOrder(new List<int> { 1, 2, 3 }))
            {
                Console.WriteLine(item);
            }
        }

        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            List<T> result = new List<T>();
            foreach (var c in iterable.ToList())
                if (result.LastOrDefault().Equals(null) || !result.LastOrDefault().Equals(c))
                    result.Add(c);
            return result;
        }
    }
}