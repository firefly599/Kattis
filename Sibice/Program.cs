using System;

namespace Sibice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sibice
            int[] lengths = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            double hyp = Math.Sqrt((Math.Pow(lengths[1], 2) + Math.Pow(lengths[2], 2)));
            for (int i =0; i < lengths[0]; i++)
            {
                float size = float.Parse(Console.ReadLine());
                
                if (size <= hyp)
                {
                    Console.WriteLine("DA");
                }
                else
                {
                    Console.WriteLine("NE");
                }
            }
        }
    }
}
