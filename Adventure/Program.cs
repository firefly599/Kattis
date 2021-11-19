using System;
using System.Collections.Generic;

namespace Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Grand Adventure
            string adventure;
            List<char> backpack = new List<char>();
            int journeys = int.Parse(Console.ReadLine());
            int length;
            bool cont;
            char top;
            for (int i = 0; i < journeys; i++)
            {
                backpack.Clear();
                adventure = Console.ReadLine();
                cont = true;
                length = 0;
                for (int j = 0; j < adventure.Length; j++)
                {
                    // Adds item to backpack
                    if (adventure[j] == '$')
                    {
                        backpack.Add('m');
                    }
                    else if (adventure[j] == '|')
                    {
                        backpack.Add('i');
                    }
                    else if (adventure[j] == '*')
                    {
                        backpack.Add('g');
                    }
                    
                    // Gets the top item
                    length = backpack.Count;
                    if (length == 0)
                    {
                        top = ' ';
                    }
                    else
                    {
                        top = backpack[backpack.Count - 1];
                    }
                    // Checks all options of dealers
                    if (adventure[j] == 't' && top != 'i')
                    {
                        cont = false;
                    }
                    else if (adventure[j] == 't' && top == 'i')
                    {
                        backpack.RemoveAt(length - 1);
                        length--;
                    }
                    else if (adventure[j] == 'j' && top != 'g')
                    {
                        cont = false;
                    }
                    else if (adventure[j] == 'j' && top ==  'g')
                    {
                        backpack.RemoveAt(length - 1);
                        length--;
                    }
                    else if (adventure[j] == 'b' && top != 'm')
                    {
                        cont = false;
                    }
                    else if (adventure[j] == 'b' && top == 'm')
                    {
                        backpack.RemoveAt(length - 1);
                        length--;
                    }
                }
                if (cont && backpack.Count == 0)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
