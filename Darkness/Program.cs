using System;

namespace Darkness
{
    class Program
    {

        static bool CheckInRange(double[] book, double cx, double cy)
        {
            // sqrt ( (x2 - x1) ^ 2 + (y2 - y1) ^ 2)
            double x = cx - book[0];
            double y = cy - book[1];
            double distance = Math.Pow(x, 2) + Math.Pow(y, 2);
            if (distance < 64)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            // Curse the Darkness
            int tests = int.Parse(Console.ReadLine());
            int candlesAmount;
            double[,] candles;
            double[] pos;
            double[] book;
            bool light;
            for (int x = 0; x < tests; x++)
            {
                book = Array.ConvertAll(Console.ReadLine().Split(" "), double.Parse);
                candlesAmount = int.Parse(Console.ReadLine());
                candles = new double[candlesAmount, 2];
                for (int i = 0; i < candlesAmount; i++)
                {
                    pos = Array.ConvertAll(Console.ReadLine().Split(" "), double.Parse);
                    for (int j = 0; j < 2; j++)
                    {
                        candles[i, j] = pos[j];
                    }
                }

                light = false;
                for (int i = 0; i < candlesAmount; i++)
                {
                    if (CheckInRange(book, candles[i, 0], candles[i, 1]))
                    {
                        light = true;
                        Console.WriteLine("light a candle");
                        break;
                    }
                }
                
                if (!light)
                {
                    Console.WriteLine("curse the darkness");
                }
            }
        }
    }
}
