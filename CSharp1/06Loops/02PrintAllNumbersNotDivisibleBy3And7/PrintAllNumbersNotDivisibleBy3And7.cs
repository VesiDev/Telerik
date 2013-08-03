using System;


class PrintAllNumbersNotDivisibleBy3And7
{
    static void Main()
    {
        Console.WriteLine("This program prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time. Please write a number.");
        int N = int.Parse(Console.ReadLine());
        for (int i = 1; i <= N; i++)
        {            
            if(i%21!=0)
            {
             Console.Write("{0},", i);
            }
        }
    }
}