//Write a program that gets two numbers from the console and prints the greater of them. 
//Don’t use if statements.

using System;

namespace _05Get2NumbersFromConsoleAndPrintTheGreater
{
    class Get2NumbersAndPrintTheGreater
    {
        static void Main()
        {
            Console.WriteLine("Please write the first number");
            int int1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please write the second number");
            int int2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The greater number is {0}", ((int1>int2)? int1 : int2));            

        }
    }
}
