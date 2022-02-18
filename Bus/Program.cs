using System;

namespace Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bus
            int tests = int.Parse(Console.ReadLine());
            int stops;
            double people;
            for (int i = 0; i < tests; i++)
            {
                stops = int.Parse(Console.ReadLine());
                people = 0;
                for (int j = 0; j < stops; j++)
                {
                    people += 0.5;
                    people += (people / 2);
                }
                Console.WriteLine(people);
                Console.WriteLine((int)people);
            }
        }
    }
}

