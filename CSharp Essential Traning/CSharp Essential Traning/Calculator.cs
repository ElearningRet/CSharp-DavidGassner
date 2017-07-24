using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEssentialTraning
{
    class Calculator
    {
        static void Main(string[] arg)
        {
            // get the vaules for the operation
            double value1 = GetData("Enter value 1: ");
            double value2 = GetData("Enter value 2: ");
            string operation;

            // holds the results of the operations
            //double result = 0;

            //Main loop - break out after completing a valid operation
            while (true)
            {
                Console.WriteLine("Choose your opprator -> (A)dd, (S)ubtract, (M)ultiply or (D)ivide");
                operation = Console.ReadLine().ToUpper();

                switch (operation)
                {
                    case "A":
                        Console.WriteLine("{0} + {1} = {2}", value1, value2, Addition(value1, value2));
                        break;

                    case "S":
                        Console.WriteLine("{0} - {1} = {2}", value1, value2, Subtraction(value1, value2));
                        break;


                    case "M":
                        Console.WriteLine("{0} * {1} = {2}", value1, value2, Multiplication(value1, value2));
                        break;

                    case "D":
                        Console.WriteLine("{0} / {1} = {2}", value1, value2, Divide(value1, value2));
                        break;


                    default:
                        Console.WriteLine("\nChoose a valid operation of A, S, M, or D");
                        continue;
                        //break;
                }
                // made it here - kick out of While-Loop
                break;
            }

        }

        static double GetData(string label)
        {
            double inputData; // return this

            // loop until valid input is accepted
            while (true)
            {
                Console.WriteLine(label);
                string input = Console.ReadLine();

                // determins when to kick out of While-Loop
                // parses string to double if fails returns 0 (false) else returns a value (true)
                if(Double.TryParse(input, out inputData))
                {
                    return inputData;
                }
                else
                {
                    Console.WriteLine("Invalid entry, try again");
                }
            }

        }

        static double Addition(double value1, double value2)
        {
            return value1 + value2;
        }

        static double Subtraction(double value1, double value2)
        {
            return value1 - value2;
        }

        static double Multiplication(double value1, double value2)
        {
            return value1 * value2;
        }

        static double Divide(double value1, double value2)
        {
            if(value1 == 0 || value2 == 0)
            {
                return 0;
            }
            return value1 / value2;
        }
        
    }
}
