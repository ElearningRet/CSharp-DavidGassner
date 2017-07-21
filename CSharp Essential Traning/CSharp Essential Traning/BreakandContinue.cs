using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEssentialTraning
{
    class BreakandContinue
    {
        enum Fruit { Apple, Orange, Fig };

        static void Main(string[] arg)
        {
            var thisFruit = Fruit.Apple;
            
            switch(thisFruit)
            {
                case Fruit.Apple:
                    Console.WriteLine("You chose Apple");
                    break; // breaks jumps to the bottom of the switch()

                case Fruit.Fig:
                    Console.WriteLine("You chose Fig");
                    break; // breaks jumps to the bottom of the switch()

                case Fruit.Orange:
                    Console.WriteLine("You chose Orange");
                    break; // breaks jumps to the bottom of the switch()

                default:
                    Console.WriteLine("You chose something else");
                    break;

            }

            Fruit[] groceries = { Fruit.Apple, Fruit.Apple, Fruit.Orange };

            Console.WriteLine("\nGrocery list");
            int apples = 0;
            foreach (var item in groceries)
            {
                //if (item == Fruit.Orange)
                //{
                //    break;
                //}
                if (item == Fruit.Apple)
                {
                    apples++;
                    if (apples>1)
                    {
                        break;      // kicks out of the foreach loop and ends loop
                        continue;   // skips rest of code in loop and goes to the next itereation of the loop
                                    // can only be used in loops 
                    }
                }
                Console.WriteLine(item);
            }
            Console.WriteLine("End of grocery list");
        }
    }
}
