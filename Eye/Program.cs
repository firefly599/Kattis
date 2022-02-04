using System;

namespace Eye
{
    class Program
    {
        static void Main(string[] args)
        {
            // Eye of Sauron
            string input = Console.ReadLine();
            int left = 0;
            int right = 0;
            bool rightSide = false;
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == '|' && !(rightSide))
                {
                    left++;
                }
                else if (input[i] == '|' && (rightSide))
                {
                    right++;
                }

                if (input[i] == ')')
                {
                    rightSide = true;
                }
            }
            if (left == right)
            {
                Console.WriteLine("correct");
            }
            else
            {
                Console.WriteLine("fix");
            }
        }
    }
}
