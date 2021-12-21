using System;

namespace TSP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Travelling Salesperson 2D
            int points = int.Parse(Console.ReadLine());
            float[][] coords = new float[points][];
            for (int i = 0; i < points; i++)
            {
                coords[i] = Array.ConvertAll(Console.ReadLine().Split(" "), float.Parse);
            }
            foreach (float[] xy in coords)
            {
                Console.WriteLine(xy[0] +" "+ xy[1]);
            }

        }
    }
}