using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEssentialTraning
{
    class WhileLoop
    {
        static void Main(string[] args)
        {
            int counter = 1;
            int maximum = 10;

            // While loop examples
            while (counter <= maximum)
            {
                Console.WriteLine("Loop numner {0}", counter);
                counter++;

            }

            string welcome = "Hello World!";
            counter = 0;
            Console.WriteLine("\nOutput from the While loop");
            while(counter < welcome.Length)
            {
                Console.WriteLine(welcome[counter]);
                counter++;
            }

            // Do loop example
            Console.WriteLine("\nOutput from Do-While loop");
            counter = 0;
            do
            {
                Console.WriteLine(welcome[counter]);
                counter++;
            } while (counter < welcome.Length);
        }
    }
}
