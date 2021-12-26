using System;

namespace Lost
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lost Lineup
            int position;
            int people = int.Parse(Console.ReadLine());
            int[] order = new int[1];
            int[] sorted = new int[] { 1 };
            if (people > 1)
            {
                order = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                sorted = new int[order.Length + 1];
                sorted[0] = 1;
                for (int i = 0; i < order.Length; i++)
                {
                    position = 1 + order[i];
                    sorted[position] = i + 2;
                }
            }
            
            foreach (int pos in sorted)
            {
                Console.Write("{0} ", pos);
            }
        }
    }
}
