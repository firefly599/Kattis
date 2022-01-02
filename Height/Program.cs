using System;

namespace Height
{
    class Program
    {
        static void Main(string[] args)
        {
            // Height ordering
            int tests = int.Parse(Console.ReadLine());
            int[] heights;
            int steps;
            int temp;
            for (int x = 0; x < tests; x++)
            {
                steps = 0;
                heights = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                for (int i = 1; i < heights.Length; i++)
                {
                    for (int j = 1; j < i; j++)
                    {
                        if (heights[i] < heights[j])
                        {
                            temp = heights[j];
                            heights[i] = heights[j];
                            heights[j] = temp;
                            steps += Math.Abs(i - j);
                            break;
                        }
                    }
                }
                Console.WriteLine("{0} {1}", heights[0], steps);
            }
        }
    }
}
