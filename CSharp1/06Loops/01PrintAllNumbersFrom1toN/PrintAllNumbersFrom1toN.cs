using System;

class PrintAllNumbersFrom1toN
{
    static void Main()
    {
        Console.WriteLine("This program prints all the numbers from 1 to N. Please write a number:");
        int N = int.Parse(Console.ReadLine());
        for (int i = 1; i <= N; i++)
        {
            Console.Write("{0},", i);
        }
    }
}

