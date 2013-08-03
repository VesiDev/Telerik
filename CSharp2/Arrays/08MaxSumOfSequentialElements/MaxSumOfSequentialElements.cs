//Write a program that finds the sequence of maximal sum in given array. Example:
//{2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}
//Can you do it with only one loop (with single scan through the elements of the array)?

using System;
using System.Text;
using System.Collections.Generic;

class MaxSumOfSequentialElements
{
    static void Main()
    {
        Console.WriteLine("This program finds the sequence of maximal sum in given array.Please enter N and the elements in the array");
        int lenghtOfArr = int.Parse(Console.ReadLine());
        int[] arr = new int[lenghtOfArr];
              
        //entering the elements in array
        for (int i = 0; i < lenghtOfArr; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }       
        //scanning the elements
        int numsOfSeqEl = 0;
        int numOfMaxSeqElements=0;
        int maxSum= 0;
        int startElementInex = 0;
        int maxSeqStartElInex = 0; 
        for (int j = 1; j <= lenghtOfArr; j++)
        {
            numsOfSeqEl = j;
            int num = 0;
            int sum = 0;
            while (num < numsOfSeqEl)
            {
                sum += arr[num];
                num++;
            }
            if (j == 1)
            {
                maxSum = sum;
            }
            startElementInex = 0;
            for (int i = numsOfSeqEl; i < lenghtOfArr; i++)
            {
                sum = sum + arr[i] - arr[i - numsOfSeqEl];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    startElementInex = (i - numsOfSeqEl + 1);
                    maxSeqStartElInex = startElementInex; 
                    numOfMaxSeqElements = numsOfSeqEl;                    
                }
            }
        }
        //Print the max sum 
        StringBuilder maxSeqStr = new StringBuilder();
        for (int i = maxSeqStartElInex; i < maxSeqStartElInex + numOfMaxSeqElements; i++)
        {
            maxSeqStr.Append(arr[i] + " ");            
        }
        Console.WriteLine("Maximal sum is {0} Maximal sequence is {1}", maxSum, maxSeqStr.ToString());
    }
}

