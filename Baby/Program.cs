using System;

namespace baby
{
    class Program
    {
        static void Main(string[] args)
        {
            // Baby Bites
            int numbers = int.Parse(Console.ReadLine());
            string[] named = Console.ReadLine().Split(" ");
            bool correct = true;
            int counter = 1;
            for (int i = 0; i < numbers; i++)
            {
               
                if (int.TryParse(named[i], out int current))
                {

                    if (!(counter == current))
                    {
                        correct = false;
                    }
                }
                counter++;
            }
            if (correct)
            {
                Console.WriteLine("makes sense");
            }
            else
            {
                Console.WriteLine("something is fishy");
            }
        }
    }
}
