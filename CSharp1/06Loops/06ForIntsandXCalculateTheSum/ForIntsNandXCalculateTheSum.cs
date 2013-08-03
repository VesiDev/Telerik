/* Write a program that reads a number N and calculates the sum of the first N members
 * of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
 * Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members. */

using System;

using System.Text;

class FibonacciMembers
{
    static void Main()
    {
        Console.Write("N = ");
        int inputN = int.Parse(Console.ReadLine());

        long firstNum = 0;
        long secondNum = 1;
        long nextNum;
        StringBuilder builder = new StringBuilder(); //Here we will keep all the members from Fibonacci sequence

        for (int i = 2; i <= inputN; i++)
        {
            nextNum = firstNum + secondNum;
            firstNum = secondNum;
            secondNum = nextNum;
            builder.Append(nextNum).Append(Environment.NewLine); //Appends next number from the sequence on a new line
        }

        Console.WriteLine(builder);
    }
}
