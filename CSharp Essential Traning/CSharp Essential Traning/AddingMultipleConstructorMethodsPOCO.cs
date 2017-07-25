using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEssentialTraning
{
    class AddingMultipleConstructorMethodsPOCO
    {
        static void Main(string[] arg)
        {
            var produce = new List<object>();

            // adding Fruit or Vegetable to the produce container
            // method one
            // now using the custom constructor to pass all info to the object f1
            var f1 = new Fruit("Apple",8.5,3);
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
    class Fruit
    {
        //No arguments constructor
        public Fruit()
        {

        }

        // custom constructor
        public Fruit(string name, double weight, int quantity)
        {
            Name = name;
            Weight = weight;
            Quantity = quantity;
        }

        private string name;

        public string Name { get => name.ToUpper(); set => name = value; }
        public double Weight { get => weight; set => weight = value; }

        private double weight;

        // shorthand method of get and set
        public int Quantity { get; set; }

        // overriding the ToString() Method to what we want it to display
        public override string ToString()
        {
            return Name + " (" + Weight + "oz) :" + Quantity;
        }

    }
    class Vegetable
    {
        //No arguments constructor
        public Vegetable()
        {

        }

        // custom constructor
        public Vegetable(string name, double weight, int quantity)
        {
            Name = name;
            Weight = weight;
            Quantity = quantity;
        }

        private string name;

        public string Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }

        private double weight;

        // shorthand method of get and set
        public int Quantity { get; set; }

        // overriding the ToString() Method to what we want it to display
        public override string ToString()
        {
            return Name + " (" + Weight + "oz) :" + Quantity;
        }
    }
}
