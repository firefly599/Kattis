using System;
using System.Collections.Generic;

namespace Daylight
{
    class Program
    {
        static void Main(string[] args)
        {
            // Saving Daylight
            string line;
            string[] start;
            string[] end;
            string[] split;
            while (!String.IsNullOrEmpty(line = Console.ReadLine()))
            {
                split = line.Split(" ");
                start = split[3].Split(":");
                end = split[4].Split(":");

                int hours = int.Parse(end[0]) - int.Parse(start[0]);
                int minutes = int.Parse(end[1]) - int.Parse(start[1]);
                if (minutes < 0)
                {
                    hours--;
                    minutes = 60 + minutes;
                }
                Console.WriteLine("{0} {1} {2} {3} hours {4} minutes", split[0], split[1], split[2], hours, minutes);
            }
        }
    }
}
