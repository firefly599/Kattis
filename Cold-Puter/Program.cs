using System;

namespace Cold_Puter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cold-puter Science
            int temperatures = int.Parse(Console.ReadLine());
            int[] temps = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int total = 0;
            foreach (int temp in temps)
            {
                if (temp < 0)
                {
                    total++;
                }
            }
            Console.WriteLine(total);
        }
    }
}
