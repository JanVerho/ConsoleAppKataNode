using System;
using System.Text;

namespace ConsoleAppKataNode
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Kata.Stringify(new Node(1, new Node(2, new Node(2)))));
        }
    }

    public class Kata
    {
        public static string Stringify(Node list)
        {
            // Write your code here
            StringBuilder s = new StringBuilder(list.Data.ToString());

            while (!(list.Next == null))
            {
                s.Append(" -> ");
                list = list.Next;

                s.Append(list.Data.ToString());
            }

            s.Append(" -> null");

            return s.ToString();
        }
    }

    public class Node
    {
        public int Data { get; private set; }
        public Node Next { get; private set; }

        public Node(int data, Node next = null)
        {
            Data = data;
            Next = next;
        }
    }
}