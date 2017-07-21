using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEssentialTraning
{
    class ReusuableCodewithMethods
    {
        const int Value1 = 12;
        const int Value2 = 24;

        static void Main(string[] args)
        {
            int total = Add(Value1, Value2);


            Console.WriteLine("The total of {0} and {1} is {2}.",Value1, Value2, total);

            int result;
            AddToOutParam(Value1, Value2, out result);
            Console.WriteLine("The total of {0} and {1} is {2} by using a void method.", Value1, Value2, result);
        }

        // method does not alter anything but passes the result back
        // stardard way of doing things
        static int Add(int value1, int value2)
        {
            return value1 + value2;
        }

        // method alters the "result" 
        // alternate way of doing things
        static void AddToOutParam(int value1, int value2, out int result)
        {
            result = value1 + value2;
        }
    }
}
