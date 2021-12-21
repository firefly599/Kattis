using System;

namespace Grading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Grading
            int[] bounds = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int score = int.Parse(Console.ReadLine());
            if (score >= bounds[0])
            {
                Console.WriteLine("A");
            }
            else if (score >= bounds[1])
            {
                Console.WriteLine("B");
            }
            else if (score >= bounds[2])
            {
                Console.WriteLine("C");
            }
            else if (score >= bounds[3])
            {
                Console.WriteLine("D");
            }
            else if (score >= bounds[4])
            {
                Console.WriteLine("E");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
