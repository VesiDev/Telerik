using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02ReadTheRadiusAndPrintParameterAndArea
{
    class Get2NumbersFromConsoleAndPrintsTheGreater
    {
        static void Main(string[] args)
        {
            double pi =Math.PI;
            Console.WriteLine("Please write a readius");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("The parameter of the circle is {0} and the area is {1}", (2*pi*radius), (pi*radius*radius));
        }
    }
}
