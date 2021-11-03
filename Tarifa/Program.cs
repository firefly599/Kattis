using System;

namespace Tarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tarifa
            int allowed = 0;
            int used;
            int megabytes = int.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());

            allowed += megabytes;
            for (int i = 0; i < months; i++)
            {
                used = int.Parse(Console.ReadLine());
                allowed += megabytes - used;
            }
            Console.WriteLine(allowed);
        }
    }
}
