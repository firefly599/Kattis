using System;

namespace Differences
{
    class Program
    {
        static void Main(string[] args)
        {
            // Detailed Differences
            int test = int.Parse(Console.ReadLine());
            string first;
            string second;
            string simular;
            for (int t = 0; t < test; t++)
            {
                first = Console.ReadLine();
                second = Console.ReadLine();
                simular = "";
                for (int i = 0; i < first.Length; i++)
                {
                    if (first[i] == second[i])
                    {
                        simular += ".";
                    }
                    else
                    {
                        simular += "*";
                    }
                }
                Console.WriteLine(first);
                Console.WriteLine(second);
                Console.WriteLine(simular);
                Console.WriteLine("");
            }
        }
    }
}
