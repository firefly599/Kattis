using System;

namespace QALY
{
    class Program
    {
        static void Main(string[] args)
        {
            // Quality-Adjusted Life-Year
            int periods = int.Parse(Console.ReadLine());
            float QALY = 0;
            for (int i = 0; i < periods; i++)
            {
                float[] values = Array.ConvertAll(Console.ReadLine().Split(" "), float.Parse);
                QALY += values[0] * values[1];
            }
            Console.WriteLine(QALY.ToString("F3"));
        }
    }
}
