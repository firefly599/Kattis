using System;

namespace Speeding
{
    class Program
    {
        static void Main(string[] args)
        {
            // Speeding
            int samples = int.Parse(Console.ReadLine());
            float[] control = new float[] { 0, 0 };
            float speed = 0;
            int max = 0;
            for (int i = 0; i < samples; i++)
            {
                float[] data = Array.ConvertAll(Console.ReadLine().Split(" "), float.Parse);
                if (i != 0)
                {
                    speed = ((data[1] - control[1]) / (data[0] - control[0]));
                    if (speed > max)
                    {
                        max = (int)speed;
                    }
                }
                control = data;
            }
            Console.WriteLine(max);
        }
    }
}
