using ConsoleApp.Model;
using ConsoleApp.ProduceExtendingClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class CreatingMethodsThatAcceptSubclassedObjects
    {
        static void Main(string[] arg)
        {
            var produce = new List<Produce>();

            produce.Add(new Fruit("Apple", 8.5, 3));
            produce.Add(new Fruit("Bananna", 4.5, 7));
            produce.Add(new Vegetable("Carrot", 4.1, 16));

            Console.WriteLine("There are {0} items",produce.Count);

            foreach (var item in produce)
            {
                Console.WriteLine(item + ", " + ProduceUtility.GetItemWeight(item) + "oz");
            }

        }
    }
}
