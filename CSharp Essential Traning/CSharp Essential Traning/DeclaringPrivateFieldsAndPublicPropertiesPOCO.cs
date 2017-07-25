using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEssentialTraning
{
    class RepresentingDataWithPlainOldClassObjects
    {
        static void Main(string[] arg)
        {
            var produce = new List<object>();

            // adding Fruit or Vegetable to the produce container
            // method one
            var f1 = new Fruit();
            var f2 = new Fruit();
            produce.Add(f1);
            produce.Add(f2);

            // method two without the var xx reference
            produce.Add(new Vegetable());

            Console.WriteLine("There are {0} items", produce.Count);
            foreach (var item in produce)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Fruit
    { }
    class Vegetable
    { }
}
