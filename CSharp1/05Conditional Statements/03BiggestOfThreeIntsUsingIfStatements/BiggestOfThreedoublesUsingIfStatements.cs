//Write a program that finds the biggest of three integers using nested if statements.



using System;

class BiggestOfThreedoublesUsingIfStatements
{
    static void Main()
    {
        Console.WriteLine("This program finds the biggest of three integers using nested if statements.");
        Console.WriteLine("Write a three real numbers.");
        int firstInt = int.Parse(Console.ReadLine());
        int secondInt = int.Parse(Console.ReadLine());
        int thirdInt = int.Parse(Console.ReadLine());

        if (firstInt > secondInt)
        {
            if (firstInt > thirdInt)
                Console.WriteLine("The biggest number is {0}", firstInt);
            else
            {
                Console.WriteLine("The biggest number is {0}", thirdInt);
            }
        }
        else
        {
            if (secondInt > thirdInt)
            {
                Console.WriteLine("The biggest number is {0}", secondInt);
            }
            else
            {
                Console.WriteLine("The biggest number is {0}", thirdInt);
            }
        }
    }
}

