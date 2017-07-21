using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEssentialTraning
{
    class ForEachLoop
    {
        static void Main(string[] arg)
        {
            string[] names = { "Aby", "Behtany", "Christel", "Joanna", "Maya", "Victoria" };

            Console.WriteLine("Output of For-Each loop");
            //foreach(var girls in names) <-- this will work too with "var" implicit type
            foreach(string girls in names)
            {
                Console.WriteLine(girls);
            }
        }
    }
}
