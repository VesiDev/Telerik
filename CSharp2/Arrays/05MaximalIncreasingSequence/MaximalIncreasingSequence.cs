//Write a program that finds the maximal increasing sequence in an array. 
//Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.

using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.WriteLine("Please write the lenght of the array and the elements of the array");
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];
        int firstIndexOfRepeatingEl = 0;
        int firstIndexOfMaxRepeatingEl = 0;
        int currentNumOfRepeatingElements = 1;
        int maxNumOfRepeatingElements = 1;
        arr[0] = int.Parse(Console.ReadLine());
        for (int i = 1; i <length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            if (arr[i] > arr[i - 1])
            {
                
                currentNumOfRepeatingElements++;
                if (currentNumOfRepeatingElements > maxNumOfRepeatingElements)
                {
                    maxNumOfRepeatingElements = currentNumOfRepeatingElements;
                    firstIndexOfMaxRepeatingEl = firstIndexOfRepeatingEl;
                }
            }
            else
            {
                firstIndexOfRepeatingEl = i;
                currentNumOfRepeatingElements = 1;              
            }            
        }
        if (maxNumOfRepeatingElements == 1)
        {
            Console.WriteLine("There is no increasing sequence in the array! ");
        }
        else
        {
            Console.WriteLine("maximal increasing sequence in the array is: ");
            for (int j = firstIndexOfMaxRepeatingEl; j < firstIndexOfMaxRepeatingEl + maxNumOfRepeatingElements; j++)
            {
                Console.Write("{0} ", arr[j]);
            }
        }
    }
}
