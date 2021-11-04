using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // Homework
            string[] questions = Console.ReadLine().Split(";");
            string[] split;
            int first;
            int last;
            int total = 0;
            foreach (string group in questions)
            {
                split = group.Split("-");
                if (split.Length > 1)
                {  
                    first = int.Parse(split[0]);
                    last = int.Parse(split[1]);
                    total += last - first + 1;
                }
                else
                {
                    total++;
                }
            }
            Console.WriteLine(total);
        }
    }
}
