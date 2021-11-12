using System;
using System.Collections.Generic;

namespace Booking
{
    class Program
    {
        static void Main(string[] args)
        {
            // Booking a Room
            int[] rooms = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            List<int> booked = new List<int>();
            int room;
            for (int i = 0; i < rooms[1]; i++)
            {
                room = int.Parse(Console.ReadLine());
                booked.Add(room);
            }
            booked.Sort();
            bool filled = true;
            for (int i = 1; i <= rooms[0]; i++)
            {
                if (!(booked.Contains(i)))
                {
                    filled = false;
                    Console.WriteLine(i);
                    break;
                }
            }
            if (filled)
            {
                Console.WriteLine("too late");
            }
        }
    }
}
