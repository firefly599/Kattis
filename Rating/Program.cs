using System;

namespace Rating
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rating Problems
            int[] judges = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int needed = judges[0] - judges[1];
            float total = 0;
            for (int i = 0; i < judges[1]; i++)
            {
                total += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(((total - (3*needed))/judges[0]) + " " + ((total + (3*needed))/judges[0]));
        }
    }
}
