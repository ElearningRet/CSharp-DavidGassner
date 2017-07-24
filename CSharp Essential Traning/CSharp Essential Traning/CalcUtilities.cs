using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEssentialTraning
{
    class CalcUtilities
    {
        // all the methods are set to public so that they can be referenced from other programs 
        // within the same project

        public static double Addition(double value1, double value2)
        {
            return value1 + value2;
        }

        public static double Subtraction(double value1, double value2)
        {
            return value1 - value2;
        }

        public static double Multiplication(double value1, double value2)
        {
            return value1 * value2;
        }

        public static double Divide(double value1, double value2)
        {
            if (value1 == 0 || value2 == 0)
            {
                return 0;
            }
            return value1 / value2;
        }

    }
}
