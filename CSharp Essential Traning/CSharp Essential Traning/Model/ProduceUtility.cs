using ConsoleApp.ProduceExtendingClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Model
{
    class ProduceUtility
    {
        public static double GetItemWeight(Produce item)
        {
            return item.Weight * item.Quantity;
        }
    }
}
