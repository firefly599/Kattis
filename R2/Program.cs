using System;

namespace R2
{
    class Program
    {
        static void Main(string[] args)
        {
            // R2
            int[] values = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int target = values[1] * 2;
            Console.WriteLine(target - values[0]);
        }
    }
}
