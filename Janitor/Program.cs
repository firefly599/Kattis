using System;

namespace Janitor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Janitor Troubles
            int[] values = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            double side = 0;
            foreach (int num in values)
            {
                side += num;
            }
            side /= 2;
            double area = Math.Sqrt((side - values[0]) *
                                    (side - values[1]) * 
                                    (side - values[2]) *
                                    (side - values[3]));

            Console.WriteLine(area);
        }
    }
}
