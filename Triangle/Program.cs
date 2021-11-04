using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Triangle Area
            float[] lengths = Array.ConvertAll(Console.ReadLine().Split(" "), float.Parse);
            float area = (lengths[0] * lengths[1]) / 2;
            Console.WriteLine(area);
        }
    }
}
