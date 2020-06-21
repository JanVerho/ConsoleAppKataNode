using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace ConsoleAppRegExprMath
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(DivisibleByThree("1891009"));

            string input = ";:%gdfgdf23{}4dg54gf*23oP4^^[]2";
            double doubleFirst = 0;
            double doubleSecond = 0;
            double doubleResult = 0;

            //Instantiating Regex Object
            Regex re = new Regex(@"['\*','\-', '/','+']");

            char[] opertors = new char[] { '*', '-', '/', '+' };

            for (int i = 0; i < opertors.Length; i++)
            {
                bool contains = input.Contains(opertors[i]);
                Console.WriteLine(contains);

                if (contains)
                {
                    string[] parts = re.Split(input);

                    Console.WriteLine(parts[0]);
                    re = new Regex(@"[a-z,A-Z,'%','$',',','[','/', '\\','{','}','\]','(','),'?','<','>,'^','*',';',:']");
                    parts[0] = re.Replace(parts[0], "");
                    Console.WriteLine(parts[0]);
                    doubleFirst = double.Parse(parts[0]);

                    Console.WriteLine(parts[1]);
                    parts[1] = re.Replace(parts[1], "");
                    Console.WriteLine(parts[1]);
                    doubleSecond = double.Parse(parts[1]);

                    switch (opertors[i])
                    {
                        case '+':
                            doubleResult = doubleFirst + doubleSecond;
                            break;

                        case '-':
                            doubleResult = doubleFirst - doubleSecond;
                            break;

                        case '/':
                            doubleResult = doubleFirst / doubleSecond;
                            break;

                        case '*':
                            doubleResult = doubleFirst * doubleSecond;
                            break;

                        default:
                            break;
                    }

                    Console.WriteLine(Math.Round(doubleResult).ToString());
                }
            }
        }

        public static bool DivisibleByThree(string n)
        {
            int sum = 0;
            foreach (char c in n)
            {
                sum = sum + int.Parse(c.ToString());
            }
            return (sum % 3) == 0;
        }
    }
}