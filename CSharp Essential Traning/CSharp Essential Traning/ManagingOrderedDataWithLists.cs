using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpEssentialTraning
{
    class ManagingOrderedDataWithLists
    {
        static void Main(string[] arg)
        {
            var fruitList = new List<string>();

            fruitList.Add("Apple");
            fruitList.Add("Oranges");
            fruitList.Add("Fig");

            Console.WriteLine("Fruit in my list:");
            foreach (var item in fruitList)
            {
                Console.WriteLine(item);
            }

            // there are many methods to choose from that manipulates the lst
            fruitList.Sort();
            Console.WriteLine("\nFruit in my list sorted:");
            foreach (var item in fruitList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nAre there any figs in the list?");
            ReportonFigs(fruitList);
        }


        static void ReportonFigs(List<string> items)
        {
            string figReport =
                items.Contains("Fig",StringComparer.OrdinalIgnoreCase) ?
                "Yes there are figs." :
                "No there are no figs.";

            Console.WriteLine(figReport);

        }
    }
}
