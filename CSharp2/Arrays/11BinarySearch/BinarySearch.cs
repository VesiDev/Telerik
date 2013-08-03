//Write a program that finds the index of given element
//in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).
using System;

class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("This program finds the index of given element in a sorted array of integers by using the binary search algorithm. Please enter an integer");
        int N = 16;       
        int searchedEl = int.Parse(Console.ReadLine());        
        int[] arr = new int[N];
        int searchedIndex = -1;
        bool isElemInArr = true;
        for (int i = 0; i < N; i++)
        {
           arr[i] = i;
        }
        int minValue = 0;
        int maxValue = N-1;
        int mid;

        while (true)
        {
            if (searchedEl > arr[maxValue] || searchedEl < arr[minValue])
            {
                isElemInArr = false;
                break;
            }
            else
            {
                isElemInArr = true;
                mid = minValue + (maxValue - minValue) / 2;
                
                if (arr[mid] > searchedEl)
                {
                    maxValue = mid-1;
                }
                else if (arr[mid] < searchedEl)
                {
                    minValue = mid+1;
                }
                else
                {
                    searchedIndex = mid;
                    break;
                }                
            }
        }
        if (isElemInArr == false)
        {
            Console.WriteLine("Element {0} is not in the array", searchedEl);
        }
        else
        {
            Console.WriteLine("Element {0} has index {1}", searchedEl, searchedIndex);
        }
    }
}
