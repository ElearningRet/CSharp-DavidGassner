using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEssentialTraning
{
    class MultidementionalArrays
    {
        static void Main(string[] arg)
        {

            // number of comma's indicate number of dimentions in array
            string[,] sections = new string[3, 3];

            sections[0, 0] = "top left";
            sections[0, 1] = "top center";
            sections[0, 2] = "top right";

            sections[1, 0] = "middle left";
            sections[1, 1] = "middle center";
            sections[1, 2] = "middle right";

            sections[2, 0] = "bottom left";
            sections[2, 1] = "bottom center";
            sections[2, 2] = "bottom right";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j <3; j++)
                {
                    Console.Write(sections[i, j] + "\t" );
                    if((j+1) %3 == 0)
                    {
                        Console.WriteLine("");
                    }
                }

            }
        }
    }
}
