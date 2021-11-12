using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            // Above average
            int cases = int.Parse(Console.ReadLine());
            float total;
            float mean;
            float average;
            float above;
            for (int i = 0; i < cases; i++)
            {
                total = 0;
                above = 0;
                float[] scores = Array.ConvertAll(Console.ReadLine().Split(" "), float.Parse);
                for (int j = 1; j < scores.Length; j++)
                {
                    total += scores[j];
                }

                mean = total / scores[0];
                for (int j = 1; j < scores.Length; j++)
                {
                    if (scores[j] > mean)
                    {
                        above++;
                    }
                }
                average = (above / scores[0]) * 100;
                Console.WriteLine("{0}%", average.ToString("f3"));

            }
        }
    }
}
