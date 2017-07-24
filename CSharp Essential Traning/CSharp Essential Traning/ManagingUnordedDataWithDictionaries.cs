using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEssentialTraning
{
    class ManagingUnordedDataWithDictionaries
    {
        static void Main(string[] arg)
        {
            // dictionary<key, value>
            // key is usually a string
            // value can be any data type
            var inventory = new Dictionary<string, double>();

            inventory.Add("Figs", 56);
            inventory.Add("Apples", 23);
            inventory.Add("Oranges", 12);

            var keys = inventory.Keys;

            Console.WriteLine("Number of items: {0}", keys.Count);

            Console.WriteLine("\nInventory List:");
            foreach (var key in keys)
            {
                Console.WriteLine(key + " : " + inventory[key]);
            }

        }
    }
}
