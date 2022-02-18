using System;
using System.Collections.Generic;

namespace Pea
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pea Soup and Pancakes
            int tests = int.Parse(Console.ReadLine());
            bool peas;
            bool pans;
            string name;
            string input;
            List<string> resturants = new List<string>();
            for (int i = 0; i < tests; i++)
            {
                int menuOptions = int.Parse(Console.ReadLine());
                name = Console.ReadLine();
                peas = false;
                pans = false;
                for (int j = 0; j < menuOptions; j++)
                {
                    input = Console.ReadLine();   
                    if (input == "pea soup")
                    {
                        peas = true;
                    }
                    if (input == "pancakes")
                    {
                        pans = true;    
                    }
                }

                if (peas & pans)
                {
                    resturants.Add(name);
                } 
            }
            if (resturants.Count == 0)
            {
                Console.WriteLine("Anywhere is fine I guess");
            }
            else
            {
                Console.WriteLine(resturants[0]);
            }
        }
    }
}
