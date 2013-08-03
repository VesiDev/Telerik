
//Write a program that reads two arrays from the console and
//compares them element by element.
using System;

class CompareTwoArrays
{
    static void Main()
    {
        Console.WriteLine("This program compares two arrays element by element.\nPlease enter the length of the first array and its elements");
        int lengthFA = int.Parse(Console.ReadLine());
        int[] firstAarray = new int[lengthFA];

        for (int i = 0; i < lengthFA; i++)
        {
            firstAarray[i] = int.Parse(Console.ReadLine());
        }
       
        Console.WriteLine("Please write the length of the second array and its elements");
        
        int lengthSA = int.Parse(Console.ReadLine());
        
        bool areArraysEqual = true;

        if (lengthSA != lengthFA)
        {
            areArraysEqual = false;
        }
        else
        {
            int[] secondAarray = new int[lengthSA];
            for (int i = 0; i < lengthSA; i++)
            {
                secondAarray[i] = int.Parse(Console.ReadLine());
                if (firstAarray[i] != secondAarray[i])
                {
                    areArraysEqual = false;
                    break;
                }
            }
        }
        if (areArraysEqual== false)
        {
            Console.WriteLine("Arrays are not equal");
        }
        else
        {
            Console.WriteLine("Arrays are equal");
        }
    }
}
