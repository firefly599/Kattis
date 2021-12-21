using System;

namespace Duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            // No Duplicates
            bool rep = false;
            string[] line = Console.ReadLine().Split(" ");
            for (int i = 0; i < line.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (line[i] == line[j])
                    {
                        rep = true;
                        break;  
                    }
                }
                if (rep)
                {
                    break;
                }
            }
            if (rep)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("yes");
            }
        }
    }
}
