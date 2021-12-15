using System;

namespace cake
{
    class Program
    {
        static void Main(string[] args)
        {
            // Shattered Cake
            int width = int.Parse(Console.ReadLine());
            int pieces = int.Parse(Console.ReadLine());
            int size = 0;
            for (int i = 0; i < pieces; i++)
            {
                int[] dimensions = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                size += (dimensions[0] * dimensions[1]);
            }
            Console.WriteLine(size/width);
        }
    }
}
