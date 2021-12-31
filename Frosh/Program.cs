using System;
using System.Linq;
using System.Collections.Generic;

namespace Frosh
{
    class Program
    {
        static void Main(string[] args)
        {
            // Frosh Week
            List<int> completedTime = new List<int>();
            List<int> completedTask = new List<int>();
            List<double> task = new List<double>();
            List<double> time = new List<double>();
            int[] tests = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int last;
            int total = 0;
            double[] timeForTask = Array.ConvertAll(Console.ReadLine().Split(" "), double.Parse);
            double[] timeForWork = Array.ConvertAll(Console.ReadLine().Split(" "), double.Parse);
            bool tooLarge = false;

            foreach (double value in timeForTask)
            {
                task.Add(value);
            }
            foreach (double value in timeForWork)
            {
                time.Add(value);
            }

            task.Sort();
            time.Sort();
            last = 0;
            for (int i = 0; i < time.Count; i++)
            {
                for (int j = last; j < task.Count; j++)
                {
                    if (time[time.Count - 1] < task[j])
                    {
                        tooLarge = true;
                    }
                    if (time[i] >= task[j] && !(completedTask.Contains(j)) && !(completedTime.Contains(i)))
                    {
                        completedTime.Add(i);
                        completedTask.Add(j);
                        last = j;
                        total++;
                        break;
                    }
                    if (task[j] > time[i])
                    {
                        break;
                    }
                }
                if (tooLarge)
                {
                    break;
                }
            }
            Console.WriteLine(total);
        }
    }
}
