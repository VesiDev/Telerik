using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11ExchangeValuesOf2IntegerVariables
{
    class Program
    {
        static void Main()
        {
            int value1 = 5;
            int value2 = 10;
            Console.WriteLine("Before the exchange value1 = {0} value2 = {1}", value1, value2);
            int swift = value1;
            value1 = value2;
            value2 = swift;
            Console.WriteLine("After the exchange value1 = {0} value2 = {1}", value1, value2);

        }
    }
}
