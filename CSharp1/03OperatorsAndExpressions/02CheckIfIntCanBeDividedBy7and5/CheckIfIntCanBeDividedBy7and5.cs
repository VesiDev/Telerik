//Task 2: Write a boolean expression that checks for given integer if it can be divided 
//(without remainder) by 7 and 5 in the same time.

using System;

namespace _02CheckIfIntCanBeDividedBy7and5
{
    class CheckIfIntCanBeDividedBy7and5
    {
        static void Main()
        {
            int valueToCheck;
            Console.WriteLine("Please enter an integer to check if it can be divided (without remainder) by 7 and 5 in the same time.");
            if (int.TryParse(Console.ReadLine(), out valueToCheck) == true)
            {
                if(valueToCheck==0)
                    Console.WriteLine("You have writen " + valueToCheck + " Dividing 0 by any number is 0");
                else if (valueToCheck % 35 == 0)
                    Console.WriteLine(valueToCheck + "  can be divided (without remainder) by 7 and 5 in the same time.");
                else 
                    Console.WriteLine(valueToCheck + "  cannot be divided (without remainder) by 7 and 5 in the same time.");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}

