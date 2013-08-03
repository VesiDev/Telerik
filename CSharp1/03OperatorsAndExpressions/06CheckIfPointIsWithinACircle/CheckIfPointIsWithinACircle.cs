//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;

namespace _06CheckIfPointIsWithinACircle
{
    class CheckIfPointIsWithinACircle
    {
        static void Main()
        {
            int radius = 5;    
           
            decimal coordinate1;
            decimal coordinate2;
            Console.WriteLine("This program Checks if a point is within a circal K(0,5).");
            Console.WriteLine("Please enter the coordinate1");
            if (decimal.TryParse(Console.ReadLine(), out coordinate1) == false)
                Console.WriteLine("Invalid input");
            else
            {
                Console.WriteLine("Please enter the coordinate2");
                if (decimal.TryParse(Console.ReadLine(), out coordinate2) == false)
                    Console.WriteLine("Invalid input");
                else
                {
                    if ((coordinate1 * coordinate1 + coordinate2 * coordinate2) <= radius * radius)
                    {
                        Console.WriteLine("The point with coordinates {0} and  {1} is within the circle K(0,5)", coordinate1, coordinate2); 
                    }
                    else 
                    {
                        Console.WriteLine("The point with coordinates {0} and  {1} is out of the circle K(0,5)", coordinate1, coordinate2); 
                    }
                }
            }          
            
            

        }
    }
}
