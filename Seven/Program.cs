using System;

namespace Seven
{
    class Program
    {
        static void Main(string[] args)
        {
            // Seven Wonders
            string input = Console.ReadLine();
            int tablet = 0;
            int compass = 0;
            int gear = 0;
            double score = 0;
            for (int letter = 0; letter < input.Length; letter++)
            {
                if (input[letter] == 'T')
                {
                    tablet++;
                }
                else if (input[letter] == 'C')
                {
                    compass++;
                }
                else
                {
                    gear++;
                }
            }
            score += Math.Pow(tablet, 2);
            score += Math.Pow(gear, 2);
            score += Math.Pow(compass, 2);

            while (tablet > 0 && compass > 0 && gear > 0)
            {
                score += 7;
                tablet--;
                compass--;
                gear--;
            }

            Console.WriteLine(score);
        }
    }
}
