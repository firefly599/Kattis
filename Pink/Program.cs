using System;

namespace Pink
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fifty Shades of Pink
            int tests = int.Parse(Console.ReadLine());
            string word;
            string[] key = {"pink", "rose"};
            int train = 0;
            for (int i = 0; i < tests; i++)
            {
                word = Console.ReadLine();
                word = word.ToLower();
                for (int j = 0; j < 2; j++)
                {
                    if (word.Contains(key[j]))
                    {
                        train++;
                        break;
                    }
                }
            }
            if (train != 0)
            {
                Console.WriteLine(train);
            }
            else
            {
                Console.WriteLine("I must watch Star Wars with my daughter");
            }
        }
    }
}
