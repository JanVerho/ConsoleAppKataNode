using System;
using System.Linq;

namespace ConsoleAppNorthSouthEastWest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
            string[] b = new string[] { "WEST" };

            string[] result = dirReduc(a);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static string[] dirReduc(String[] arr)
        {
            var result = new string[] { };

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1) { result.Prepend(arr[i]); break; }
                if ((arr[i + 1] == "NORTH" && arr[i] != "SOUTH") || (arr[i] == "NORTH" && arr[i + 1] != "SOUTH") && (arr[i + 1] == "WEST" && arr[i] != "EAST") || (arr[i] == "WEST" && arr[i + 1] != "EAST"))
                {
                    result.Prepend(arr[i]);
                }
            }

            return result;
        }
    }
}