using System;
using System.Linq;

namespace Mjehuric
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mjehuric
            int temp;
            int[] array = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int[] sorted = new int[] {1, 2, 3, 4, 5};
            while (!Enumerable.SequenceEqual(array, sorted))
            {
                for (int i = 0; i < 4; i++)
                {
                    if (array[i] > array[i+1])
                    {
                        temp = array[i];
                        array[i] = array[i+1];
                        array[i+1] = temp;
                        Console.WriteLine("{0} {1} {2} {3} {4}", array[0], array[1], array[2], array[3], array[4]);
                    }
                }
            }
        }
    }
}
