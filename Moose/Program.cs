using System;

namespace Moose
{
    class Program
    {
        static void Main(string[] args)
        {
            // Judging Moose
            int[] tinds = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            if (tinds[0] == tinds[1] && Math.Max(tinds[0], tinds[1]) > 0)
            {
                Console.WriteLine("Even {0}", tinds[0]*2);
            }
            else if (tinds[0] == 0 && tinds[1] == 0)
            {
                Console.WriteLine("Not a moose");
            }
            else
            {
                Console.WriteLine("Odd {0}", Math.Max(tinds[0], tinds[1]) * 2);
            }
        }
    }
}
