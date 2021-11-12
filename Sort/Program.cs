using System;
using System.Collections.Generic;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort of Sorting
            int values;
            string word;
            string temp;
            

            values = int.Parse(Console.ReadLine());
            string[] names = new string[values];
            while (true)
            {
                for (int i = 0; i < values; i++)
                {
                    word = Console.ReadLine();
                    names[i] = word;
                }

                for (int i = 0; i < values; i++)
                {
                    for (int j = 0; j < values-1; j++)
                    {
                        // Compares the first 2 letters of the names
                        string first = names[j].Substring(0, 2);
                        string second = names[j+1].Substring(0, 2);

                        if (String.Compare(first, second) > 0)
                        {
                            temp = names[j+1];
                            names[j+1] = names[j];
                            names[j] = temp;
                        }
                        
                    }
                }

                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }

                values = int.Parse(Console.ReadLine());
                if (values == 0)
                {
                    break;
                }
                Console.WriteLine("");
                names = new string[values];
                
            }
        }
    }
}
