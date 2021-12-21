using System;

namespace avion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Avion
            string reg;
            string blimps = "";
            for (int i = 1; i <= 5; i++)
            {
                reg = Console.ReadLine();
                for (int j = 2; j < reg.Length; j++)
                {
                    if (reg[j] == 'I' && reg[j-1] == 'B' && reg[j-2] == 'F')
                    {
                        blimps += i.ToString() + " ";
                    }  
                }
            }
            if (blimps.Length != 0)
            {
                Console.WriteLine(blimps);
            }
            else
            {
                Console.WriteLine("HE GOT AWAY!");
            }
        }
    }
}
