using System;

namespace QALY
{
    class Program
    {
        static void Main(string[] args)
        {
            // Quality-Adjusted Life-Year
            float ratio;
            float years;
            int periods = int.Parse(Console.ReadLine());
            float QALY = 0;
            for (int i = 0; i < periods; i++)
            {
                ratio = float.Parse(Console.ReadLine());
                years = float.Parse(Console.ReadLine());
                QALY += ratio * years;
            }
            Console.WriteLine(QALY.ToString("F3"));
        }
    }
}
