using System;

namespace Compass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Jumbled Compass
            int current = int.Parse(Console.ReadLine());
            int target = int.Parse(Console.ReadLine());
            int difference = target - current;
            if (Math.Abs(difference) > 180)
            {
                if (difference > 0)
                {
                    difference = - (360 - Math.Abs(difference));
                }
                else
                {
                    difference = 360 - Math.Abs(difference);
                }
            }
            Console.WriteLine(difference);
        }
    }
}
