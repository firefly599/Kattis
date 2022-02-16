using System;

namespace Datum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Datum
            int[] date = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            DateTime day = new DateTime(2009, date[1], date[0]);
            Console.WriteLine(day.DayOfWeek);
        }
    }
}
