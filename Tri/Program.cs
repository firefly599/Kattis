using System;

namespace Tri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tri
            int[] values = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            if ((values[0] + values[1]) == values[2])
            {
                Console.WriteLine(values[0] + "+" + values[1] + "=" + values[2]);
            }
            else if ((values[0] - values[1]) == values[2])
            {
                Console.WriteLine(values[0] + "-" + values[1] + "=" + values[2]);
            }
            else if ((values[0] * values[1]) == values[2])
            {
                Console.WriteLine(values[0] + "*" + values[1] + "=" + values[2]);
            }
            else if ((values[0] / values[1]) == values[2])
            {
                Console.WriteLine(values[0] + "/" + values[1] + "=" + values[2]);
            }
            else if (values[0] == (values[1] + values[2]))
            {
                Console.WriteLine(values[0] + "=" + values[1] + "+" + values[2]);
            }
            else if (values[0] == (values[1] - values[2]))
            {
                Console.WriteLine(values[0] + "=" + values[1] + "-" + values[2]);
            }
            else if (values[0] == (values[1] * values[2]))
            {
                Console.WriteLine(values[0] + "=" + values[1] + "*" + values[2]);
            }
            else if (values[0] == (values[1] / values[2]))
            {
                Console.WriteLine(values[0] + "=" + values[1] + "/" + values[2]);
            }

        }
    }
}
