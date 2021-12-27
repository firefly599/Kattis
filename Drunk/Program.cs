using System;

namespace Drunk
{
    class Program
    {
        static void Main(string[] args)
        {
            // Drunk Vigenère
            int encryptedValue;
            int keyValue;
            int decryptedValue;
            string encrypted = Console.ReadLine();
            string key = Console.ReadLine();
            string decrypted = "";
            for (int i = 0; i < encrypted.Length; i++)
            {
                encryptedValue = (int)encrypted[i];
                keyValue = (int)key[i];
                if ((i+1) % 2 == 0)
                {
                    decryptedValue = encryptedValue + (keyValue - 65);
                    if (decryptedValue > 90)
                    {
                        decryptedValue = 65 + (decryptedValue % 91);
                    }
                
                }
                else
                {
                    decryptedValue = encryptedValue - (keyValue - 65);
                    if (decryptedValue < 65)
                    {
                        decryptedValue = 90 - (64 - decryptedValue);
                    }
                }
                decrypted += (char)decryptedValue;
                
            }
            Console.WriteLine(decrypted);
        }
    }
}
