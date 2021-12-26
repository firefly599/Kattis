using System;
using System.Linq;

namespace Knot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Knot Knowledge
            int knots = int.Parse(Console.ReadLine());
            int[] required = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int[] learnt = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            foreach (int knot in required)
            {
                if (!(learnt.Contains(knot)))
                {
                    Console.WriteLine(knot);
                    break;
                }
            }
        }
    }
}
