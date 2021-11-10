using System;

namespace Nasty
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nasty Hacks
            int cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                int[] values = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                if (values[0] < values[1] - values[2])
                {
                    Console.WriteLine("advertise");
                }
                else if (values[0] == values[1] - values[2])
                {
                    Console.WriteLine("does not matter");
                }
                else
                {
                    Console.WriteLine("do not advertise");
                }
            }
        }
    }
}
