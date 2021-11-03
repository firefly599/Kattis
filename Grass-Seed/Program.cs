using System;

namespace Grass_Seed
{
    class Program
    {
        static void Main(string[] args)
        {
            // Grass Seed Inc.
            float cost = float.Parse(Console.ReadLine());
            int amount = int.Parse(Console.ReadLine());
            float total = 0;
            float area;
            for (int i = 0; i < amount; i++)
            {
                float[] lengths = Array.ConvertAll(Console.ReadLine().Split(" "), float.Parse);
                area = lengths[0] * lengths[1];
                total += cost * area;
            }
            Console.WriteLine(total);
        }
    }
}
