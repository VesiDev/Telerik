//Sorting an array means to arrange its elements in increasing order. 
//Write a program to sort an array. Use the "selection sort" algorithm: 
//Find the smallest element, move it at the first position, find the smallest from the rest,
//move it at the second position, etc.
using System;

class SelectionSort
{
    static void Main()
    {
        Console.WriteLine("This program sorts an array using selection sort.");
        Console.WriteLine("Please enter the number of elements in the array and the elements in the array");
        int arrLength = int.Parse(Console.ReadLine());
        int[] arr = new int[arrLength];
        for (int i = 0; i < arrLength; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        
        int positionFound = 0;
        int minValue = int.MaxValue;
        int switchVal; 
        for (int elementToFill = 0; elementToFill < arrLength; elementToFill++)//Fill with sorted elements
        {
            minValue = int.MaxValue;
            //search for min value from first not sorted element
            for (int element = elementToFill; element < arrLength; element++)
            {
                if (arr[element] < minValue)
                {
                    minValue = arr[element];
                    positionFound = element;
                }
            }

            //Save the Minimum Value at elementToFill position and the value of elementToFill in origianl minValue position. 
            switchVal = arr[elementToFill];
            arr[elementToFill] = minValue;
            arr[positionFound] = switchVal;
            Console.Write("{0,1} ", arr[elementToFill]);
        }
    }
}