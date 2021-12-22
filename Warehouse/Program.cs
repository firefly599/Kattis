using System;
using System.Linq;
using System.Collections.Generic;

namespace Warehouse
{
    public class Item
    {
        public string name;
        public int amount;

        public Item (string name, int amount)
        {
            this.name = name;
            this.amount = amount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Warehouse
            List<Item> items = new List<Item>();
            int test = int.Parse(Console.ReadLine());
            string[] item;
            bool existing;
            // Loops for each of the warehouses
            for (int i = 0; i < test; i++)
            {
                items.Clear();
                int amount = int.Parse(Console.ReadLine());
                // Loops for each of the items to be added
                for (int j = 0; j < amount; j++)
                {
                    existing = false;
                    item = Console.ReadLine().Split(" ");
                    // Loops to check if the item does exist already
                    for (int k = 0; k < items.Count; k++)
                    {
                        if (items[k].name == item[0])
                        {
                            existing = true;
                            items[k].amount += int.Parse(item[1]);
                        }
                    }
                    // if not existing add the data
                    if (!existing)
                    {
                        Item obj = new Item(item[0], int.Parse(item[1]));
                        items.Add(obj);
                    }
                }

                List<Item> sorted = items.OrderByDescending(o=>o.amount).ThenBy(o=>o.name).ToList();
                Console.WriteLine(items.Count);
                foreach (Item obj in sorted)
                {
                    Console.WriteLine("{0} {1}", obj.name, obj.amount);
                }
            }
        }
    }
}
