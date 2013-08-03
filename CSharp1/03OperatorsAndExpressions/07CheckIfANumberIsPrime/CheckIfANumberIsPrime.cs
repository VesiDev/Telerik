using System;


namespace _07CheckIfANumberIsPrime
{
    class CheckIfANumberIsPrime
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number lower then 100");
            int valueToCheck;
            Console.WriteLine("Please enter an integer to check if it is odd or even");
            if (int.TryParse(Console.ReadLine(), out valueToCheck) == true)
            {
                if (valueToCheck<=100&&valueToCheck % 2 != 0&&valueToCheck % 3 != 0&&valueToCheck % 5 != 0&&valueToCheck % 7 != 0)
                    Console.WriteLine(valueToCheck+" is prime");
                else Console.WriteLine(valueToCheck+" is not prime");
            }
            else
            {
                Console.WriteLine("Invalid input");            
            }

            
        }
    }
}
