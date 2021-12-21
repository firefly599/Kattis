using System;

namespace Musical
{
    class Program
    {
        static void Main(string[] args)
        {
            // Musical Notation
            int amount;
            int totalLength = 0;
            char[] bands = new char[] {'G', 'F', 'E', 'D', 'C', 'B', 'A', 'g', 'f', 'e', 'd', 'c', 'b', 'a'};
            string[] notes = new string[14];
            int length = int.Parse(Console.ReadLine());
            string[] song = Console.ReadLine().Split(" ");

            // Runs for each note to be played
            for (int i = 0; i < length; i++)
            {
                // Loops over all pitches
                for (int j = 0; j < bands.Length; j++)
                {
                    // If pitch matches note add it
                    if (song[i].Length == 1)
                    {
                        amount = 1;
                    }
                    else
                    {
                        amount = song[i][1] - '0';
                    }
                    totalLength += amount;
                    if (song[i][0] == bands[j])
                    {
                        // Adds the asterisk
                        for (int k = 0; k < amount; k++)
                        {
                            notes[j] += "*";
                        }
                        notes[j] += " ";
                    }
                    else
                    {
                        for (int k = 0; k <= amount; k++)
                        {
                            notes[j] += " ";
                        }
                    }
                }
            }

            string special = "FDBgea";
            for (int i = 0; i < notes.Length; i++)
            {
                notes[i] = notes[i].Remove(notes[i].Length - 1, 1); 
                if (special.Contains(bands[i]))
                {
                    notes[i] = notes[i].Replace(' ', '-');
                }
                Console.WriteLine("{0}: {1}", bands[i], notes[i]);
            }
        }
    }
}
