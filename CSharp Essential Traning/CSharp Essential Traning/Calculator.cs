using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEssentialTraning
{
    class Calculator
    {
        static void Main(string[] arg)
        {
            double value1 = 0;
            double value2 = 0;
            string operation;

            Console.WriteLine("Enter value #1:");
            value1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value #2:");
            value2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose your opprator -> (A)dd, (S)ubtract, (M)ultiply or (D)ivide");
            operation = Convert.ToString(Console.Read());

            switch (operation)
            {
                case A:
                    Console.WriteLine("{0} + {1} = {2}", value1, value2, Addition(value1, value2));
                    break;

                case S:
                    Console.WriteLine("{0} - {1} = {2}", value1, value2, Subtraction(value1, value2));
                    break;


                case M:
                    Console.WriteLine("{0} * {1} = {2}",value1, value2, Multiplication(value1,value2));
                    break;

                case D:
                    Console.WriteLine("{0} / {1} = {2}", value1, value2, Divide(value1, value2));
                    break;


                default:
                    break;
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
            return value1 / value2;
        }
        
    }
}
