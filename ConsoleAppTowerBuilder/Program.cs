using System;
using System.Linq;
using System.Collections;
using System.IO;

namespace ConsoleAppTowerBuilder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            foreach (string item in TowerBuilder(5))
            {
                Console.WriteLine(item);
            }
        }

        public static string[] TowerBuilder(int nFloors)
        {
            string[] tower = new string[nFloors];

            string str = "*";
            for (int i = 0; i < tower.Length - 1; i++)
            {
                str += "**";
            }
            char[] strArray = str.ToArray();
            for (int x = 0; x < tower.Length; x++)
            {
                foreach (char item in strArray)
                {
                    tower[tower.Length - 1 - x] += item.ToString();
                }
                strArray[x] = ' ';
                strArray[strArray.Length - 1 - x] = ' ';
            }

            return tower;
        }
    }
}