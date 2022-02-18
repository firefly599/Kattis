using System;

namespace RLE
{
    class Program
    {
        static string Encode(string input)
        {
            string output = "";
            int counter = 0;
            char current = input[0];
            for (int i = 0; i < input.Length; i++)
            {
                if (current == input[i])
                {
                    counter++;
                }
                else
                {
                    output += current + counter.ToString();
                    current = input[i];
                    counter = 1;
                }
            }
            output += current + counter.ToString();
            return output;
        }

        static string Decode(string input)
        {
            string output = "";
            char current;
            int amount;
            for (int i = 0; i < input.Length; i = i + 2)
            {
                current = input[i];
                amount = input[i+1] - '0';
                for (int j = 0; j < amount; j++)
                {
                    output += input[i];
                }
            }
            return output;
        }

        static void Main(string[] args)
        {
            // Run-Length Encoding, Run!
            string[] input = Console.ReadLine().Split(" ");
            string output;
            if (input[0] == "E")
            {
                output = Encode(input[1]);
            }
            else
            {
                output = Decode(input[1]);
            }
            Console.WriteLine(output);
        }
    }
}
