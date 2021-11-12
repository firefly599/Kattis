using System;

namespace Statues
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3D Printed Statues
            int statues = int.Parse(Console.ReadLine());
            int days = 1 + (int)Math.Ceiling(Math.Log(statues) / Math.Log(2));
            Console.WriteLine(days);
        }
    }
}
