//Task 1:Write an expression that checks if given integer is odd or even.

//An even number is an integer that is "evenly divisible" by 2, i.e., divisible by 2 without remainder; 
//an odd number is an integer that is not evenly divisible by 2.

using System;

namespace _01CheckIfIntegerIsOddOrEven
{
    class CheckIfIntegerIsOddOrEven
    {
        static void Main()
        {
            int valueToCheck;
            Console.WriteLine("Please enter an integer to check if it is odd or even");
            if (int.TryParse(Console.ReadLine(), out valueToCheck) == true)
            {
                if (valueToCheck % 2 == 0)
                    Console.WriteLine(valueToCheck+" is even number");
                else Console.WriteLine(valueToCheck+" is odd number");
            }
            else
            {
                Console.WriteLine("Invalid input");            
            }
        }
    }
}
