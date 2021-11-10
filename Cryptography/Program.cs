using System;

namespace Cryptography
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Key to Cryptography
            string encyp = Console.ReadLine();
            string key = Console.ReadLine();
            string combined = key + encyp;
            combined = combined.Substring(0, encyp.Length);
            int shift;
            int value;
            string decyp = "";
            for (int i = 0; i < encyp.Length; i++)
            {
                decyp = (char) 
            }
            Console.WriteLine(decyp);
        }
    }
}
