using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            // Final Exam
            int total = 0;
            int tests = int.Parse(Console.ReadLine());
            string next;
            string current = Console.ReadLine();
            for (int i = 0; i < tests; i++)
            {
                next = Console.ReadLine();
                if (current == next)
                {
                    total ++;
                }
                current = next;
            }
            Console.WriteLine(total);
        }
    }
}
