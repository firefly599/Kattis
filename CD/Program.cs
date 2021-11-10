    using System;
    using System.Collections.Generic;

    namespace CD
    {
        class Program
        {
            static void Main(string[] args)
            {
                // CD
                HashSet<int> cds = new HashSet<int>();
                int total;
                int value;
                while (true)
                {
                    int[] owned = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                    if (owned[0].Equals(0) && owned[1].Equals(0))
                    {
                         break;
                    }
                    total = owned[1] + owned[0];
                    
                    for (int i = 0; i < total; i++)
                    {
                        value = int.Parse(Console.ReadLine());
                        cds.Add(value);
                    }
                    Console.WriteLine(total - cds.Count);
                }
            }
        }
    }
