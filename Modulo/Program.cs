using System;
using System.Collections.Generic;

namespace Modulo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Modulo
            int number;
            List<int> distinct = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (!(distinct.Contains(number % 42)))
                {
                    distinct.Add(number % 42);
                }
            }
            Console.WriteLine(distinct.Count);
        }
    }
}
