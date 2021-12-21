using System;

namespace Ladder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ladder
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            double angle = numbers[1] * (Math.PI / 180);
            double dis = numbers[0] / Math.Sin(angle);
            Console.WriteLine(Math.Ceiling(dis));
        }
    }
}
