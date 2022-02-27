using System;

namespace Ptice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ptice
            int a = 0;
            int b = 0;
            int c = 0;
            string A = "ABC";
            string B = "BABC";
            string C = "CCAABB";

            int questions = int.Parse(Console.ReadLine());
            string inut = Console.ReadLine();

            for (int i = 0; i < questions; i++)
            {
                if (inut[i] == A[i % 3])
                {
                    a++;
                }
                if (inut[i] == B[i % 4])
                {
                    b++;
                }
                if (inut[i] == C[i % 6])
                {
                    c++;
                }
            }
            int max = Math.Max(a, Math.Max(b, c));

            Console.WriteLine(max);
            if (a == max)
            {
                Console.WriteLine("Adrian");
            }
            if (b == max)
            {
                Console.WriteLine("Bruno");
            }
            if (c == max)
            {
                Console.WriteLine("Goran");
            }
        }
    }
}
