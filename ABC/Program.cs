using System;

namespace ABC
{
    class Program
    {
        static void Main(string[] args)
        {
            // ABC
            int[] values = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            Array.Sort(values);
            string order = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                if (order[i] == 'A')
                {
                    Console.Write(values[0] + " ");
                }
                else if (order[i] == 'B')
                {
                    Console.Write(values[1] + " ");
                }
                else
                {
                    Console.Write(values[2] + " ");
                }
            }
        }
    }
}
