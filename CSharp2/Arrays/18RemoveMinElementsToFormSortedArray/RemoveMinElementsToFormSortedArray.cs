using System;
using System.Collections.Generic;

class RemoveMinElementsToFormSortedArray
{

    static void Main()
    {
        Console.WriteLine("This program reads an array of N integers and removes from it a minimal number of elements in such way that the remaining array is sorted in increasing order.\nPlease enter N and the elements of the array:");
        int N = int.Parse(Console.ReadLine());
        int[] arr = new int[N];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        //N elements binary representation  - > Math.Pow(2,K)-1
        int maxOption = (int)Math.Pow(2, arr.Length);// if N = 5 elements  11111 = 31 i.e Pow(2,5)-1
        List<int> longestList = new List<int>();
        List<int> currentList = new List<int>();
        int index = -1;
        
        for (int num = 1; num < maxOption; num++)
        {
            currentList.Clear();
            index = -1;
            //chech in the binary representation of Num on which positions there are 1
            for (int position = 0; position <= arr.Length; position++)
            {
                if ((num >> position & 1) == 1)
                {
                    if (currentList.Count == 0)
                    {
                        currentList.Add(arr[position]);
                        index++;
                    }
                    else
                    {
                        if (arr[position] >=currentList[index])
                        {
                            currentList.Add(arr[position]);
                            index++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            if (index >=longestList.Count)
            {
                longestList.Clear();
                foreach (var item in currentList)
                {
                    longestList.Add(item);
                }
            }
            
        }
        Console.Write("The result array is: ");
        for (int i = 0; i < longestList.Count; i++)
        {
            Console.Write(longestList[i] + " ");
        }       
    }
}

