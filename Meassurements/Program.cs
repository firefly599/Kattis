using System;

namespace Meassurements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Imperial Measurement
            string[] sizes = new string[] {"th", "in", "ft", "yd", "ch", "fur", "mi", "lea"};
            string[] sizes2 = new string[] {"thou", "inch", "foot", "yard", "chain", "furlong", "mile", "league"};
            int[] scale = new int[] {1000, 12, 3, 22, 10, 8, 3};
            string[] conversion = Console.ReadLine().Split(" ");
            double current = double.Parse(conversion[0]);
            int start = Array.IndexOf(sizes, conversion[1]);
            int end = Array.IndexOf(sizes, conversion[3]);
            if (start == -1)
            {
                start = Array.IndexOf(sizes2, conversion[1]);
            }
            if (end == -1)
            {
                end = Array.IndexOf(sizes2, conversion[3]);
            }
            int difference = end - start;
            bool multiply = false;
            if (difference < 0)
            {
                multiply = true;
                difference *= -1;
            }

            while (start != end)
            {
                if (multiply)
                {
                    current *= scale[start - 1]; 
                    start--;
                }
                else
                {
                    current /= scale[start];
                    start++;
                }
            }
            Console.WriteLine(current);
        }
    }
}
