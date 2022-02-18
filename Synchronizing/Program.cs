using System;
using System.Collections.Generic;

namespace Synchronizing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Synchronizing Lists
            int tests;
            int num;
            int index;
            int[] original;
            int[] second;
            int[] copy;

            tests = int.Parse(Console.ReadLine());
            while (true)
            {
                original = new int[tests];
                second = new int[tests];
                copy = new int[tests];

                for (int i = 0; i < tests * 2; i++)
                {
                    num = int.Parse(Console.ReadLine());
                    if (i < tests)
                    {
                        original[i] = num;
                    }
                    else
                    {
                        second[i-tests] = num;
                    }
                }

                Array.Copy(original, copy, tests);
                Array.Sort(copy);
                Array.Sort(second);

                for (int i = 0; i < tests; i++)
                {
                    index = Array.IndexOf(copy, original[i]);
                    Console.WriteLine(second[index]);
                }
                tests = int.Parse(Console.ReadLine());
                if (tests == 0)
                {
                    break;
                }
                Console.WriteLine("");
            }
        }
    }
}
