using System;

namespace gears
{
    class Program
    {
        static double maxTorque(int[] values)
        {
            double T;
            double x = (-values[1]) / (-2 * (double) values[0]);
            T = -values[0] * x * x + values[1] * x + values[2];
            return T;
        }
        static void Main(string[] args)
        {
            // Growling Gears
            int gears;
            int tests = int.Parse(Console.ReadLine());
            int[] values;
            double max;
            double[] torque;
            for (int i = 0; i < tests; i++)
            {
                max = -9999999;
                gears = int.Parse(Console.ReadLine());
                torque = new double[gears];
                for (int j = 0; j < gears; j++)
                {
                    values = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                    torque[j] = maxTorque(values);
                }
                    
                for (int j = 0; j < gears; j++)
                {
                    if (torque[j] < 0)
                    {
                        torque[j] *= -1;
                    }
                    if (torque[j] > max)
                    {
                        max = torque[j];
                    }
                }
                Console.WriteLine(Array.IndexOf(torque, max) + 1);
            }
        }
    }
}
