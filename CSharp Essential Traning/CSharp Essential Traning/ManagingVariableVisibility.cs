using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEssentialTraning
{
    class ManagingVariableVisibility
    {
        // localField is available to ALL methods since it was placed
        // on top of the Main()
        static int localField = 15;

        // static public int localField = 15;
        // adding the "public" makes it available to all classes other than ManagingVariableVisibility

        static void Main(string[] arg)
        {
            Console.WriteLine("In Main()");

            // available only within the method
            int localVar = 1;


            // int i is only available within the loop
            for (int i = 0; i < 10; i++)
            {
                // localVar is available here
                Console.WriteLine("Value of i: {0}", i);
            }

            
            Console.WriteLine("localVar is {0}", localVar);
            Console.WriteLine("localField is {0}",localField);

            CustomMethod();
        }

        static void CustomMethod()
        {
            Console.WriteLine("\nIn CustomMethod()");
            Console.WriteLine("localVar is NOT available in this CustomMethod");
            Console.WriteLine("localField IS available in this CustomMethod");
            Console.WriteLine("LocalField is {0}",localField);
        }
    }
}
