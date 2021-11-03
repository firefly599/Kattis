using System;

namespace Time_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stuck In A Time Loop
            int loop = int.Parse(Console.ReadLine());
            for (int i = 1; i <= loop; i++)
            {
                Console.WriteLine(i + " Abracadabra");
            }
        }
    }
}
