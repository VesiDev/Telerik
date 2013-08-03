//Write an expression that calculates trapezoid's area by given sides a and b and height h.


using System;


namespace _08TrapezoidArea
{
    class TrapezoidArea
    {
        static void Main()
        {
            decimal sideA;
            decimal sideB;
            decimal hight;

            Console.WriteLine("This program calculates calculates trapezoid's area by given sides a and b and height h.");
            Console.WriteLine("Please enter side A");
            if (decimal.TryParse(Console.ReadLine(), out sideA) == false)
                Console.WriteLine("Invalid input");
            else
            {
                Console.WriteLine("Please enter side B");
                if (decimal.TryParse(Console.ReadLine(), out sideB) == false)
                    Console.WriteLine("Invalid input");
                else 
                {
                    Console.WriteLine("Please enter hight");
                    if (decimal.TryParse(Console.ReadLine(), out hight) == false)
                    Console.WriteLine("Invalid input");
                    else 

                    Console.WriteLine(("Trapezoid area is:{0} " +((sideA+sideB)/2) * hight));
                }
            }          
            
        }
    }
    }


   

