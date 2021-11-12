using System;

namespace Line
{
    class Program
    {
        static void Main(string[] args)
        {
            // Line them up
            int num = int.Parse(Console.ReadLine());
            string[] names = new string[num];
            string[] asc = new string[num];
            string[] rev = new string[num];

            for (int i = 0; i < num; i++)
            {
                names[i] = Console.ReadLine();
            }
            
            Array.Copy(names, asc, names.Length);
            Array.Sort(asc);        
            Array.Copy(asc, rev, names.Length);
            Array.Reverse(rev);
    
            bool ascend = true;
            bool reverse = true;
            for (int i = 0; i < num; i++)
            {
                if (names[i] != asc[i])
                {
                    ascend = false;
                }
                if (names[i] != rev[i])
                {
                    reverse = false;
                }
            }
            if (ascend)
            {
                Console.WriteLine("INCREASING");
            }
            else if (reverse)
            {
                Console.WriteLine("DECREASING");
            }
            else
            {
                Console.WriteLine("NEITHER");
            }
            
        }
    }
}
