using System;
using System.Collections;

namespace Alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            // A New Alphabet
            Hashtable alphabet = new Hashtable();
            alphabet.Add('a', "@");
            alphabet.Add('b', "8");
            alphabet.Add('c', "(");
            alphabet.Add('d', "|)");
            alphabet.Add('e', "3");
            alphabet.Add('f', "#");
            alphabet.Add('g', "6");
            alphabet.Add('h', "[-]");
            alphabet.Add('i', "|");
            alphabet.Add('j', "_|");
            alphabet.Add('k', "|<");
            alphabet.Add('l', "1");
            alphabet.Add('m', @"[]\/[]");
            alphabet.Add('n', @"[]\[]");
            alphabet.Add('o', "0");
            alphabet.Add('p', "|D");
            alphabet.Add('q', "(,)");
            alphabet.Add('r', "|Z");
            alphabet.Add('s', "$");
            alphabet.Add('t', "']['");
            alphabet.Add('u', "|_|");
            alphabet.Add('v', @"\/");
            alphabet.Add('w', @"\/\/");
            alphabet.Add('x', "}{");
            alphabet.Add('y', "`/");
            alphabet.Add('z', "2");

            string input = Console.ReadLine();
            string output = "";
            char single;
            foreach (char character in input)
            {
                single = Char.ToLower(character);
                if (alphabet.Contains(single))
                {
                    output += alphabet[single];
                }
                else
                {
                    output += single;
                }
            }
            Console.WriteLine(output);
        }
    }
}
