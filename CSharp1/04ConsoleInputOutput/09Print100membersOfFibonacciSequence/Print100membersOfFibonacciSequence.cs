//Write a program to print the first 100 members of the sequence of Fibonacci: 
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …218922995834555169026 

using System;

class Program
{
    static void Main()
    {
        decimal n = 100, a = 0, b = 1;

        while (n-- != 0)
        {
            Console.WriteLine(a);

            b = a + b;
            a = b - a;
        }
    }
}


