using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleAppSimplePigLatin
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(MyClass.PigIt("there is a cat"));
            var random = new Random();
            string randomStr = "";
            randomStr = string.Join("", Enumerable.Range(0, 20).Select((o, x) => (char)random.Next('a', 'z') + ((x + 1) % 4 == 0 ? " " : "")));
            Console.WriteLine(randomStr);
            randomStr = string.Join("", Enumerable.Range(0, 20).Select((o, x) => (char)random.Next('A', 'Z') + ((x + 1) % 3 == 0 ? " " : "")));
            Console.WriteLine(randomStr);
            randomStr = string.Join("", Enumerable.Range(0, 20).Select((o, x) => (char)random.Next('A', 'z') + ((x + 1) % 2 == 0 ? " " : "")));
            Console.WriteLine(randomStr);
        }
    }

    public class MyClass
    {
        public static string PigIt(string str)
        {
            // Part 1: split string on spaces (this will separate all the words).
            string[] words = str.Split(' ');

            // Part 2: loop over result array.
            string wordRev = "";
            string zinRev = "";
            // Part 3: split word(this will separate all the char)
            foreach (string word in words)
            {
                wordRev = ReverseString(word);
                wordRev = wordRev + "ay ";
                Console.WriteLine("WORD: " + wordRev);
                zinRev = zinRev + wordRev;
            }
            return zinRev.Trim();
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            char firstChar = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = firstChar;

            return new string(arr);
        }
    }
}