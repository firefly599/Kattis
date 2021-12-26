using System;

namespace Pyramids
{
    class Program
    {
        static void Main(string[] args)
        {
            // Building Pyramids
            double total = 0;
            int layer = 1;
            int output = 0;
            int input = int.Parse(Console.ReadLine());
            while (true)
            {
                total += Math.Pow(layer, 2);
                if (total <= input)
                {
                    layer += 2;
                    output++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(output);
        }
    }
}
