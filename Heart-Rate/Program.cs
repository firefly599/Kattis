using System;

namespace Heart_Rate
{
    class Program
    {
        static void Main(string[] args)
        {
            // Heart Rate
            float bpm;
            float min;
            float max;
            float change;
            string[] values;
            int cases = int.Parse(Console.ReadLine());

            for (int i = 0; i < cases; i++)
            {
                values = Console.ReadLine().Split(" ");
                int b = int.Parse(values[0]);
                float p = float.Parse(values[1]);
                bpm = (60 * b) / p;
                change = bpm / b;
                max = bpm + change;
                min = bpm - change;
                Console.WriteLine(min.ToString("f4") + " " + bpm.ToString("f4") + " " + max.ToString("f4"));
            }
        }
    }
}
