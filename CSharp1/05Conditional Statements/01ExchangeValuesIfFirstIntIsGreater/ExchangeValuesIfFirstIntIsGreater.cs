//Write an if statement that examines two integer variables and exchanges their values
//if the first one is greater than the second one.

using System;

class ExchangeValuesIfFirstIntIsGreater
{
    static void Main()
    {
        Console.WriteLine
            ("This program use if statement to examine two integer variables and exchanges their values if the first one is greater than the second one.");
        Console.WriteLine("Write an integer");
        int firstInt = int.Parse(Console.ReadLine());
        Console.WriteLine("Write a second integer");
        int secondInt = int.Parse(Console.ReadLine());

        if (firstInt > secondInt)
        {
            int swift;
            swift = firstInt;
            firstInt = secondInt;
            secondInt = swift;

        }
        Console.WriteLine("First int is {0}, Second int is {1}", firstInt, secondInt);
    }
}
