//We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SubSetSum
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program  checks for 5 integer numbers if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0");
        Console.WriteLine("Write 5 integers");
        //vsichki kombinacii ot 5 chisla sa 2 na 5-ta
        int[] array = new int[5];
        int sum = 0;
        bool zeroSumFound = false;
        for (int i = 0; i < 5; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 1; i < 32; i++)
        {
            sum = 0;
            for (int j = 0; j < 5; j++)
            {
                if (((i >> j) & 1) == 1)
                {
                    sum += array[j];
                }
            }
            if (sum == 0)
            {
                Console.WriteLine("Zero subsum found");
                zeroSumFound = true;
                break;
            }
        }
        if (zeroSumFound == false)
        {
            Console.WriteLine("Zero sum not found");
        }
    }
}
   