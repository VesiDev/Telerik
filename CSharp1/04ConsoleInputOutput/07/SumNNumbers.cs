//Write a program that gets a number n and 
//after that gets more n numbers and calculates and prints their sum. 


using System;

namespace _07SumNNumbers
{
    class SumNNumbers
    {
        static void Main()
        {
            Console.WriteLine("How many numbers you would like to sum. Write a number:");
            int n = int.Parse(Console.ReadLine());
            int sum = 0; 
            for (int i = 1; i <=n; i++)
            {
                Console.Write("Please enter number {0}: ", i);
                sum += int.Parse(Console.ReadLine());                
            }
            Console.WriteLine("The sum is {0}", sum);
        }
    }
}
