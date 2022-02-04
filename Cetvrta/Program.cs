using System;

namespace Cetvrta
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cetvrta
            double[] p1 = Array.ConvertAll(Console.ReadLine().Split(" "), double.Parse);
            double[] p2 = Array.ConvertAll(Console.ReadLine().Split(" "), double.Parse);
            double[] p3 = Array.ConvertAll(Console.ReadLine().Split(" "), double.Parse);
            double x = 2 * (Math.Max(p1[0], Math.Max(p2[0], p3[0]))) + 2*(Math.Min(p1[0], Math.Min(p2[0], p3[0]))) - (p1[0] + p2[0] + p3[0]);
            double y = 2 * (Math.Max(p1[1], Math.Max(p2[1], p3[1]))) + 2*(Math.Min(p1[1], Math.Min(p2[1], p3[1]))) - (p1[1] + p2[1] + p3[1]);

            Console.WriteLine("{0} {1}", x, y);
        }
    }
}
