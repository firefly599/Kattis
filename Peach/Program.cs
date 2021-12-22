using System;
using System.Collections.Generic;
namespace Peach
{
    class Program
    {
        static void Main(string[] args)
        {
            // Saving Princess Peach
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int obstical;
            List<int> obsticals = new List<int>();
            for (int i = 0; i < numbers[1]; i++)
            {
                obstical = int.Parse(Console.ReadLine());
                if (!(obsticals.Contains(obstical)))
                {
                    obsticals.Add(obstical);
                }
            }
            for (int i = 0; i < numbers[0]; i++)
            {
                if (!(obsticals.Contains(i)))
                {
                    Console.WriteLine("{0}", i);
                }
            }
            Console.WriteLine("Mario got {0} of the dangerous obstacles.", obsticals.Count);
        }
    }
}
