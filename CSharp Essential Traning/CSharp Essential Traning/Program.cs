using System;

namespace CSharp_Essential_Traning
{
    class IfElseCommands
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first name of the person you are looking for");

            string input = Console.ReadLine();

            if(input.Equals("Aby", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Hi Ray, Aby has been waiting for you. I'll let her know you are here");
            }
            else
            {
                Console.WriteLine("Ray, I'll see if {0} is in.",input);
            }

        }
    }
}