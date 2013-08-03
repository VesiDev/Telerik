//Write a program that reads an integer number n from the console and 
//prints all the numbers in the interval [1..n], each on a single line.


using System;

namespace _08printsAllNumbersInInterval_1ToN
{
    class PrintAllNumbersInInterval_1ToN
    {
        static void Main()
        {
            Console.WriteLine("Please enter a positive number");
            int n = int.Parse(Console.ReadLine());            
            for (int i = 0; i <=n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
