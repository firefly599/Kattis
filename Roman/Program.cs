using System;

namespace roman
{
    class Program
    {
        static void Main(string[] args)
        {
            // Roaming Romans
            float distance = float.Parse(Console.ReadLine());
            double dis = Math.Round((1000f * (5280f/4854f)) * distance);
            Console.WriteLine(dis);
        }
    }
}
