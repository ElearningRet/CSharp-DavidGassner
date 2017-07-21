using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEssentialTraning
{
    class ForLoops
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Looping from 0 to 10");
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Number: {0}",i);
            }
            string[] fruit = { "Apples", "Oranges", "Grapes" };

            Console.WriteLine("\nItems in the fruit array");

            for (int i = 0; i < fruit.Length; i++)
            {
                Console.WriteLine(fruit[i]);
            }
        }
    }
}
