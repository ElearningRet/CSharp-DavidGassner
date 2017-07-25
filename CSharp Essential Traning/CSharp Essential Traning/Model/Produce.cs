using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Model
{
    class Produce
    {
        //No arguments constructor
        public Produce()
        {

        }

        // custom constructor
        public Produce(string name, double weight, int quantity)
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
