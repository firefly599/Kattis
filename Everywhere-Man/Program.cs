using System;
using System.Collections.Generic;

namespace Everywhere_Man
{
    class Program
    {
        static void Main(string[] args)
        {
            // I've Been Everywhere, Man
            int tests = int.Parse(Console.ReadLine());
            List<string> destinations = new List<string>();
            string visit;
            bool visitied = false;
            for (int i = 0; i < tests; i++)
            {
                destinations.Clear();
                int trips = int.Parse(Console.ReadLine());
                for (int j = 0; j < trips; j++)
                {
                    visit = Console.ReadLine();
                    visitied = false;
                    foreach (string place in destinations)
                    {
                        if (visit == place)
                        {
                            visitied = true;
                        }
                    }
                    if (visitied == false)
                    {
                        destinations.Add(visit);
                    }
                }
                 Console.WriteLine(destinations.Count);
                    
            }
           
        }
    }
}
