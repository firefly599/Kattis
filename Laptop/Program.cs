using System;

namespace Laptop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Laptop Sticker
            int[] sizes = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            if (sizes[2] < sizes[0] - 1 && sizes[3] < sizes[1] - 1)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
