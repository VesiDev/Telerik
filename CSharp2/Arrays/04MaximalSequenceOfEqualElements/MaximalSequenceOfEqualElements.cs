//Write a program that finds the maximal sequence of equal elements in an array.
//Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.


using System;

class MaximalSequenceOfEqualElements
{
    static void Main()
    {
        Console.WriteLine("Please write the lenght and the elements of the array");
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
            if (arr[i] == arr[i - 1])
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
            Console.WriteLine("There is no sequence of equal elements in the array! ");
        }
        else
        {
            Console.WriteLine("maximal sequence of equal elements is: ");
            for (int j = firstIndexOfMaxRepeatingEl; j < firstIndexOfMaxRepeatingEl + maxNumOfRepeatingElements; j++)
            {
                Console.Write("{0} ", arr[j]);
            }
        }

    }
}
    
