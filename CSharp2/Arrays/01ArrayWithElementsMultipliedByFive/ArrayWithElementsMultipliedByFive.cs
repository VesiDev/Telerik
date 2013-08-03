//Write a program that allocates array of 20 integers and 
//initializes each element by its index multiplied by 5.
//Print the obtained array on the console

using System;

class ArrayWithElementsMultipliedByFive
{
    static void Main()
    {
        Console.WriteLine("This program  allocates array of 20 integers,initializes each element by its index multiplied by 5 and prints the obtained array on the console");
        int length = 20;
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = i * 5;
            Console.WriteLine(array[i]);
        }
    }
}

