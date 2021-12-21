using System;

namespace hiss
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hissing Microphone
            string word = Console.ReadLine();
            int length = word.Length;
            bool hiss = false;
            for (int i = 1; i < length; i++)
            {
                if (word[i] == 's' && word[i-1] == 's')
                {
                    hiss = true;
                    break;
                }
            }
            if (hiss)
            {
                Console.WriteLine("hiss");
            }
            else
            {
                Console.WriteLine("no hiss");
            }
        }
    }
}
