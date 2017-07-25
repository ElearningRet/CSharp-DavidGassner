using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEssentialTraning
{
    class DeclaringPropertiesWithShorthandGetandSetMethodsPOCO
    {
        static void Main(string[] arg)
        {
            var produce = new List<object>();

            // adding Fruit or Vegetable to the produce container
            // method one
            var f1 = new Fruit();
            f1.Name = "Apple";
            f1.Weight = 8.5;
            f1.Quantity = 3;

            var f2 = new Fruit();
            f2.Name = "Bananna";
            f2.Weight = 5.2;
            f2.Quantity = 7;

            produce.Add(f1);
            produce.Add(f2);

            // method two without the var xx reference
            produce.Add(new Vegetable());
            ((Vegetable)produce[2]).Name = "Carrot";
            ((Vegetable)produce[2]).Weight = 6.2;
            ((Vegetable)produce[2]).Quantity = 5;
            // produce[2] points to the third piece of fruit to be added
            // [0] = apple and [1] = bananna [3] = carrot

            Console.WriteLine("There are {0} items", produce.Count);
            foreach (var item in produce)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Fruit
    {
        private string name;

        public string Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }

        private double weight;

        // shorthand method of get and set
        public int Quantity { get; set; }
    }
    class Vegetable
    {
        private string name;

        public string Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }

        private double weight;

        // shorthand method of get and set
        public int Quantity { get; set; }
    }
}
