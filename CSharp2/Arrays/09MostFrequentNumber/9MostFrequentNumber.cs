//Write a program that finds the most frequent number in an array. Example:
// {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)

using System;
using System.Collections.Generic;

class MostFrequentNumber
{
    static void Main()
    {
        Console.WriteLine("This program finds the most frequent number in an array");
        Console.WriteLine("Please enter the length of the array and its elements");
        int lenghtOfArr = int.Parse(Console.ReadLine());    
        int[] arr = new int[lenghtOfArr];
        List<int> uniqueElements = new List<int>();
        List<int> uniqueElOcurCounted = new List<int>();

        int maxOcur = 1;
        arr[0] = int.Parse(Console.ReadLine());
        uniqueElements.Add(arr[0]);
        uniqueElOcurCounted.Add(1);
        bool isUniqueElement = true;
        bool oneUniqueMaxEl = true;
        int maxOccurIndex = -1; 
        //entering the elements in array
        for (int i = 1; i < lenghtOfArr; i++)
        {
            
            arr[i] = int.Parse(Console.ReadLine());
            //check if the value is unique
            isUniqueElement = true;
            for (int j = 0; j < uniqueElements.Count; j++)
            {
                if (arr[i] == uniqueElements[j])
                {
                    uniqueElOcurCounted[j]++;
                    if (uniqueElOcurCounted[j] >=maxOcur)
                    {
                        if (uniqueElOcurCounted[j] > maxOcur)
                        {
                            maxOcur = uniqueElOcurCounted[j];
                            maxOccurIndex = j;
                            oneUniqueMaxEl = true;
                        }
                        else
                        {
                            oneUniqueMaxEl = false;
                        }
                    }
                    isUniqueElement = false;
                    break;
                }
            }
            if (isUniqueElement == true)
            {
                uniqueElements.Add(arr[i]);
                uniqueElOcurCounted.Add(1);
            }

        }
        if (maxOcur == 1)
        {
            Console.WriteLine("There are no repeating numbers");
        }
        else if (oneUniqueMaxEl == false)
        {
            Console.WriteLine("The is not a unique most frequent number in the arrays");
        }
        else
        {
            Console.WriteLine("The most frequent number is {0}. It appears {1} times.", uniqueElements[maxOccurIndex], maxOcur);
        }
    }
}
