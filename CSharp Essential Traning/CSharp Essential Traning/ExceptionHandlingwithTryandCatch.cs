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
            try
            {
                string[] fruit = { "Apples", "Oranges", "Grapes" };
                for (int i = 0; i < fruit.Length; i++)
                {
                    // throw an excption if one of the fruit is null
                    if (fruit[i] == null)
                    {
                        throw (new ArgumentNullException());
                    }
                    Console.WriteLine(fruit[i]);
                }
            }
            // create catch segments for each type of error you want to trap
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index problem");
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Null problem");
                Console.WriteLine(ex.Message);
            }
            // Finally block is always run weather or not an exption has been thrown
            finally
            {
                Console.WriteLine("Finally block as been reached");
            }
            // flow starts here if no errors in the try/catch IF there is no Finally block
            
        }
    }
}
