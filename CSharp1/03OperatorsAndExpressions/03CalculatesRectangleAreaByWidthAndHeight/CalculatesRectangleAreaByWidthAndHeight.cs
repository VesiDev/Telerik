//Task 3: Write an expression that calculates rectangle’s area by given width and height.
using System;

namespace _03CalculatesRectangleAreaByWidthAndHeight
{
    class CalculatesRectangleAreaByWidthAndHeight
    {
        static void Main()
        {
            decimal width;
            decimal hight; 
            Console.WriteLine("This program calculates rectangle's area by given width and height."); 
            Console.WriteLine("Please enter the width");
            if (decimal.TryParse(Console.ReadLine(), out width) == false)
                Console.WriteLine("Invalid input");
            else 
            {
                Console.WriteLine("Please enter the hight");
                if (decimal.TryParse(Console.ReadLine(), out hight) == false)
                   Console.WriteLine("Invalid input");
                else
                    Console.WriteLine("The area is: " + width*hight);
            }          
            
        }
    }
}
