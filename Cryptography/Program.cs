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
            
            int temp;
            char decryptedLetter;
            string decrypted = "";
            for (int i = 0; i < combined.Length; i++)
            {
                temp = (int)encyp[i] - ((int)key[i] - 65);
                if (temp < 65)
                {
                    temp = 90 - (64 - temp);
                }
                decryptedLetter = (char)temp;
                key += decryptedLetter;
                decrypted += decryptedLetter;
            }
            Console.WriteLine(decrypted);
        }
    }
}
