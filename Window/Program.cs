using System;

namespace Window
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mars Window
            int nextYear = 2018;
            int nextMonth = 4;
            int target = int.Parse(Console.ReadLine());
            while (true)
            {
                if (target < nextYear)
                {
                    Console.WriteLine("no");
                    break;
                }
                if (target == nextYear)
                {
                    Console.WriteLine("yes");
                    break;
                }
                if (target > nextYear)
                {
                    nextYear += 2;
                    nextMonth += 2;
                    if (nextMonth > 12)
                    {
                        nextYear++;
                        nextMonth -= 12;
                    }
                }
                if (target == nextYear)
                {
                    Console.WriteLine("yes");
                    break;
                }
            }
        }
    }
}
