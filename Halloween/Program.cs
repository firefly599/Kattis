using System;

namespace Halloween
{
    class Program
    {
        static void Main(string[] args)
        {
            // IsItHalloween.com
            string date = Console.ReadLine();
            if (date == "OCT 31" || date == "DEC 25")
            {
                Console.WriteLine("yup");
            }
            else
            {
                Console.WriteLine("nope");
            }
        }
    }
}
