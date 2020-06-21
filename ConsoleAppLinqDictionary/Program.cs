using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppLinqDictionary
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            foreach (var item in MyLanguages(new Dictionary<string, int> { { "Java", 10 }, { "Ruby", 80 }, { "Python", 65 } }))
            {
                Console.WriteLine(item);
            }

            string str = "klkjiKKK... klilo";
            string strResult = "";
            Char[] charArr = str.ToArray();
            foreach (char check in charArr.Where(p => p != ' ' && Char.IsLetter(p) && !Char.IsUpper(p)).Distinct().OrderByDescending(p => p).Reverse())
            {
                int countChar = charArr.Where(c => c == check).Count();
                strResult += countChar.ToString() + check.ToString();
            }
            Console.WriteLine(strResult);
        }

        public static IEnumerable<string> MyLanguages(Dictionary<string, int> results)
        {
            IEnumerable<string> Languages = results.Where(p => p.Value >= 60)
                .OrderByDescending(p => p.Value)
                .Select(p => p.Key);

            return Languages;
        }
    }
}