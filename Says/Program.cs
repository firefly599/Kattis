using System;

namespace Says
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simon says
            int tests = int.Parse(Console.ReadLine());
            int length;
            string input;
            string[] line;
            string output;
            for (int i = 0; i < tests; i++)
            {
                input = Console.ReadLine();
                line = input.Split(" ");
                output = "";
                if (line.Length > 1)
                {
                    if (line[0] == "simon" && line[1] == "says")
                    {
                        length = input.Length;
                        if (length > 10)
                        {
                            output = input.Substring(11, length-11);
                        }
                    }
                }
                
                Console.WriteLine(output);
            }
        }
    }
}
