using System;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estimating the Area of a Circle
            double totalArea;
            double estimatedArea;
            double[] values;
            values = Array.ConvertAll(Console.ReadLine().Split(" "), double.Parse);
            while (values[0] != 0 && values[1] != 0 && values[2] != 0)
            {
                totalArea = Math.Pow(values[0], 2) * Math.PI;
                estimatedArea = 4 * (values[2] / values[1]) * Math.Pow(values[0], 2);
                Console.WriteLine("{0} {1}", totalArea, estimatedArea);
                values = Array.ConvertAll(Console.ReadLine().Split(" "), double.Parse);
            } 
        }
    }
}
