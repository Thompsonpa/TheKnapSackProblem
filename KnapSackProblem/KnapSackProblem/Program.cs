using System;
using System.Collections.Generic;

/* ----------------------------------------------------------------------------------------------------------------------
 * Title: The Knap Sack Problem
 * Auther: Patrick Thompson (thompsonpa)
 * ----------------------------------------------------------------------------------------------------------------------
 * Desciption: The knapsack problem is a problem in combinatorial optimization: Given a set of items, each with a weight 
 *             and a value, determine the number of each item to include in a collection so that the total weight is less 
 *             than or equal to a given limit and the total value is as large as possible.
 *             (source: https://en.wikipedia.org/wiki/Knapsack_problem) 
 * ----------------------------------------------------------------------------------------------------------------------
*/

namespace KnapSackProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set Max Weight Amount Variable
            double KnapSack = 10.0;

            // Set Items List variable
            List<Item> Items = new List<Item>();

            // Add Items to List
            Items.Add(new Item() { weight = 2.5, value = 5.0 });
            Items.Add(new Item() { weight = 3.5, value = 4.0 });
            Items.Add(new Item() { weight = 1.5, value = 2.0 });
            Items.Add(new Item() { weight = 10.0, value = 5.0 });
            Items.Add(new Item() { weight = 5.0, value = 10.0 });
            Items.Add(new Item() { weight = 16.0, value = 9.0 });
            Items.Add(new Item() { weight = 12.0, value = 8.0 });

            // Have Items and Knapsack set up, need to solve problem on which combo will be the best value
            // first organize the list Largest First (Descending)
            Items.Sort();
            Items.Reverse();


            // Need to create formula to create an over all index value for each item
            foreach (var Package in Items)
            {
                if (Package.weight <= KnapSack)
                {

                }
            }

            Console.WriteLine("Hello World, It works");
            Console.ReadLine();
        }
    }

    class Item
    {
        public double weight { get; set; }
        public double value { get; set; }
    }
}
