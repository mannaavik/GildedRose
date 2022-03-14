using csharp.BusinessLayer;
using csharp.DataLayer;
using System;
using System.Collections.Generic;

namespace csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            // Fetch Items from data layer
            IList<Item> Items = new Product().getItems();

            // Create business logic layer instance
            var app = new Calculator(new GildedRose(Items));

            // Print output in console
            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j]);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}
