using System;

namespace Add_No
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add Two Numbers
            int[] values = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            Console.WriteLine(values[0] + values[1]);
        }
    }
}
