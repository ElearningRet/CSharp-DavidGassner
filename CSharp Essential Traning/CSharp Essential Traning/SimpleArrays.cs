using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpEssentialTraning
{
    class SimpleArrays
    {
        static void Main(string[] arg)
        {
            // open ended string array - not fixed in size
            string[] fruit = { "Apples", "Oranges", "Grapes" };

            Console.WriteLine("Values in the fruit array:");
            foreach (var item in fruit)
            {
                Console.WriteLine(item);
            }

            // string array of a fixed size
            string[] names = new string[3];
            names[0] = "Aby";
            names[1] = "Victoria";
            names[2] = "Joanna";
            //names[3] = "Amanda"; // will crash the system since it is beyond the range

            Console.WriteLine("\nValues in the names array");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            int[] weights = { 12, 34, 56, 12, 23 };
            Console.WriteLine("\nValues in int array:");
            foreach (var item in weights)
            {
                Console.WriteLine(item);
            }

            int sum = weights.Sum(); // need using System.Linq to get the .Sum() part
            double average = weights.Average();

            Console.WriteLine("\nSum of int array is: {0}", sum);
            Console.WriteLine("Average of int array is: {0}", average);

            UseArray(fruit);
            UseArray(names);
        }

        static void UseArray(string[] values)
        {
            Console.WriteLine("\nValues in method: ");
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
