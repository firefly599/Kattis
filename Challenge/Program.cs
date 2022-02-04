using System;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // A Real Challenge
            double area = double.Parse(Console.ReadLine());
            double length = Math.Sqrt(area);
            double perm = 4 * length;
            Console.WriteLine(perm);
        }
    }
}
