using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CSharpEssentialTraning
{
    class DebugTools
    {
        static void Main(string[] arg)
        {
            string[] fruit = { "Apples", "Oranges", "Grapes" };
            for (int i = 0; i <= fruit.Length; i++)
            {
                // Debug.WriteLine shows up in the Output tab at the bottom of VS
                Debug.WriteLine("Value of i is: {0}", i);
                Console.WriteLine(fruit[i]);
            }
        }
    }
}
