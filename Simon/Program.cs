using System;
using System.Collections.Generic;
namespace Simon
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simon says
            string[] line;
            int tests = int.Parse(Console.ReadLine());
            for (int i = 0; i < tests; i++)
            {
                line = Console.ReadLine().Split();
                if (line[0] == "Simon" && line[1] == "says")
                {
                    for (int j = 2; j < line.Length; j++)
                    {
                        Console.Write("{0} ", line[j]);
                    }
                    Console.WriteLine("");
                }
            }
        }
    }
}
