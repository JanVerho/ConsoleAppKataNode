using System;
using System.Security.Principal;

namespace ConsoleAppSurfaceBlock
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Block b = new Block(new int[] { 2, 4, 6 });
            Console.WriteLine(b.GetWidth()); // -> 2

            /*b.GetLength() // -> 4

            b.GetHeight() // -> 6

            b.GetVolume() // -> 48

            b.GetSurfaceArea() // -> 88*/
        }

        private class Block
        {
            //Block b = new Block(new int[]{2,4,6}) -> creates a `Block` object with a width of `2` a length of `4` and a height of `6`
            public Block(int[] intArray)
            {
                this.Width = intArray[0];
                this.Length = intArray[1];
                this.Height = intArray[2];
            }

            public int Width { get; set; }
            public int Length { get; set; }
            public int Height { get; set; }

            public int GetWidth()
            {
                return this.Width;
            }// return the width of the `Block`

            public int GetLength()
            {
                return this.Length;
            }// return the length of the `Block`

            public int GetHeight()
            {
                return this.Height;
            }// return the height of the `Block`

            public int GetVolume()
            {
                return this.Width * this.Height * this.Length;
            }// return the volume of the `Block`

            public int GetSurfaceArea()
            {
                return ((2 * this.Width * this.Height) + (2 * this.Length * this.Height) + (2 * this.Length * this.Width));
            }// return the surface area of the `Block`
        }
    }
}