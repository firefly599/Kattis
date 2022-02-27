using System;

namespace ah
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aaah!
            string firt = Console.ReadLine();
            string second = Console.ReadLine();
            if (firt.Length < second.Length)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("go");
            }
        }
    }
}
