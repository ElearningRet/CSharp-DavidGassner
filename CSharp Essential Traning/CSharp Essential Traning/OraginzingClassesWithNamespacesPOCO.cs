using ConsoleApp.ProduceExtendingClasses; // namespace where the fruit and vegetable methods resides
using System;
using System.Collections.Generic;

namespace ConsoleApp.Model
{
    class OrganizingClassesWithNamespacesPOCO
    {
        static void Main(string[] arg)
        {
            var produce = new List<object>();

            // adding Fruit or Vegetable to the produce container
            // method one
            // now using the custom constructor to pass all info to the object f1
            // at this point I could refer to the base class: Produce or the inherited class of: Fruit
            // both should work the same
            var f1 = new Fruit("Apple", 8.5, 3);
            //f1.Name = "Apple";
            //f1.Weight = 8.5;
            //f1.Quantity = 3;

            // now using the custom constructor to pass all info to the object f2
            var f2 = new Fruit("Bananna", 5.3, 7);
            //f2.Name = "Bananna";
            //f2.Weight = 5.2;
            //f2.Quantity = 7;

            // adding the objects to the produce list
            produce.Add(f1);
            produce.Add(f2);

            // method two without the var xx reference
            produce.Add(new Vegetable("Carrot", 6.2, 5));
            //((Vegetable)produce[2]).Name = "Carrot";
            //((Vegetable)produce[2]).Weight = 6.2;
            //((Vegetable)produce[2]).Quantity = 5;
            // produce[2] points to the third piece of fruit to be added
            // [0] = apple and [1] = bananna [3] = carrot

            Console.WriteLine("There are {0} items", produce.Count);
            foreach (var item in produce)
            {
                Console.WriteLine(item);
            }
        }
    }
}
