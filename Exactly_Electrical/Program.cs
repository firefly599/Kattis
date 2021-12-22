using System;

namespace Exactly_Electrical
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exactly Electrical
            int[] start = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int[] end = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int power = int.Parse(Console.ReadLine());
            int x = Math.Abs(start[0] - end[0]);
            int y = Math.Abs(start[1] - end[1]);
            int spent = power - x - y;
            if (spent % 2 == 0  && spent >= 0)
            {
                Console.WriteLine("Y");
            }
            else
            {
                Console.WriteLine("N");
            }
        }
    }
}
