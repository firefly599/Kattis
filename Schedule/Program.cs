using System;
using System.Linq;
using System.Collections.Generic;

namespace Schedule
{
    class Time
    {
        public int hour;
        public int minute;
        public string half;

        public Time(int hour, int minute, string half)
        {
            this.hour = hour;
            this.minute = minute;
            this.half = half;
        }

        public void display()
        {
            string displayMinute = this.minute.ToString();
            if (this.minute == 0)
            {
                displayMinute = "00";
            }
            Console.WriteLine("{0}:{1} {2}", this.hour, displayMinute, half);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Busy Schedule
            int input;
            List<Time> times = new List<Time>();
            List<Time> amTimes = new List<Time>();
            List<Time> pmTimes = new List<Time>();
            string[] time;
            string[] values;
            bool am;

            input = int.Parse(Console.ReadLine());
            while (true)
            {
                if (input == 0)
                {
                    break;
                }

                times.Clear();
                amTimes.Clear();
                pmTimes.Clear();
                
                // Adds each time to the list
                for (int i = 0; i < input; i++)
                {
                    time = Console.ReadLine().Split(" ");
                    values = time[0].Split(":");
                    am = false;
                    if (time[1] == "a.m.")
                    {
                        am = true;
                    }
                    Time obj = new Time(int.Parse(values[0]), int.Parse(values[1]), time[1]);
                    times.Add(obj);
                    if (am)
                    {
                        amTimes.Add(obj);
                    }
                    else
                    {
                        pmTimes.Add(obj);
                    }
                }

                // Seperates times base on am / pm
                // Sorts times by hours and minutes
                List<Time> amSorted = amTimes.OrderBy(x=>x.hour).ThenBy(x=>x.minute).ToList();
                // If a time is 12:00 push to front
                for (int i = 0; i < amSorted.Count; i++)
                {
                    Time current = amSorted[i];
                    if (current.hour == 12 && current.minute == 0)
                    {
                        Time toMove = amSorted[amSorted.Count - 1];
                        amSorted.RemoveAt(amSorted.Count - 1);
                        amSorted.Insert(0, toMove);
                        i--;
                    }
                }
                List<Time> pmSorted = pmTimes.OrderBy(x=>x.hour).ThenBy(x=>x.minute).ToList();
                for (int i = 0; i < pmSorted.Count; i++)
                {
                    Time current = pmSorted[i];
                    if (current.hour == 12 && current.minute == 0)
                    {
                        Time toMove = pmSorted[pmSorted.Count - 1];
                        pmSorted.RemoveAt(pmSorted.Count - 1);
                        pmSorted.Insert(0, toMove);
                        i--;
                    }
                }

                // Adds all the times from pmSorted to amSorted to output times
                amSorted.AddRange(pmSorted);

                foreach (Time value in amSorted)
                {
                    value.display();
                }

                amSorted.Clear();
                pmSorted.Clear();

                input = int.Parse(Console.ReadLine());
                if (input != 0)
                {
                    Console.WriteLine("");
                }
                else
                {
                    break;
                }
            }
        }
    }
}
