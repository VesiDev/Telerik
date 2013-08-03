//Write a program that reads 3 integer numbers from the console and prints their sum
using System;


namespace _01Reads3IntFromConsoleAndPrintTheirSum
{
    class Reads3IntFromConsoleAndPrintTheirSum
    {
        //TODO justifi

        static void Main()
        {
            int int1;
            int int2;
            int int3;
            Console.WriteLine("This program reads 3 integer numbers from the console and prints their sum");
            Console.WriteLine("Please enter the first integer");
            if (int.TryParse(Console.ReadLine(), out int1) == false)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                Console.WriteLine("Please enter the second integer");
                if (int.TryParse(Console.ReadLine(), out int2) == false)
                {
                    Console.WriteLine("Invalid input");
                }
                else Console.WriteLine("Please enter the third integer");
                {
                    if (int.TryParse(Console.ReadLine(), out int3) == false)
                        Console.WriteLine("Invalid input");

                    else
                        Console.WriteLine("The sum of the integers is: " + (int1 + int2 + int3));
                }
            }
        }
    }
}
