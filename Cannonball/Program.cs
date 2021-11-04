using System;

namespace Cannonball
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Amazing Human Cannonball
            double t;
            double y;
            double cos;
            double sin;
            double radians;
            double g = 9.81;
            int tests = int.Parse(Console.ReadLine());
            for (int i = 0; i < tests; i++)
            {
                double[] values = Array.ConvertAll(Console.ReadLine().Split(" "), double.Parse);
                // x = v*t*Cos($)
                // t = x / (v*Cos($))
                // y = v*t*sin($) - 1/2*g*t**2
                radians = values[1] * Math.PI / 180; // Converts Degrees to Radians 
                cos = Math.Cos(radians); 
                sin = Math.Sin(radians);
                t = values[2] / (values[0] * cos);
                y = (values[0] * t * sin) - (1f / 2f) * g * Math.Pow(t, 2);
                if ((y > (values[3]+1)) && (y < (values[4] - 1))) // 1 Meter clearance needed
                {
                    Console.WriteLine("Safe");
                }
                else
                {
                    Console.WriteLine("Not Safe");
                }
            }
        }
    }
}
