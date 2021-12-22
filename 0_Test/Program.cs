using System;
using System.Linq;

namespace _0_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temp = new int[] {1, 2};
            int[] target = new int[] {2, 1};
            if (Enumerable.SequenceEqual(temp, target))
            {
                Console.WriteLine("here");
            }
        }
    }
}
