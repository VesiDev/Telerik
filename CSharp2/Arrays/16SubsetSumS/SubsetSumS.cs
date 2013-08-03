//* We are given an array of integers and a number S.
//Write a program to find if there exists a subset of the elements of the array that has a sum S. 
//Example: arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14 -> yes (1+2+5+6)

using System;
using System.Text;

class SubsetSumS
{
    static void Main()
    {
        Console.WriteLine("This program finds if there exists a subset of the elements of the array that has a sum S");
        
        Console.WriteLine("Please enter N - number of elements in the array,S - the searched sum and the elements of the array");
        int N = int.Parse(Console.ReadLine());
        int S = int.Parse(Console.ReadLine());
        

        int[] arr = new int[N];
        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        //N elements binary representation  - > Math.Pow(2,K)-1
        int maxOption = (int)Math.Pow(2, N);// if N = 5 elements  11111 = 31 i.e Pow(2,5)-1
        int sum = 0;
        bool sumfound = false;
        StringBuilder str = new StringBuilder();
        
        for (int num = 1; num < maxOption; num++)
        {
            sum = 0;
            str.Remove(0, str.Length);
                       
            //chech in the binary representation of Num on which positions there are 1
            for (int position = 0; position < N; position++)
            {
                if ((num >> position & 1) == 1)
                {                    
                    sum += arr[position];
                    str.Append(arr[position] + " ");
                }
            }

            if (sum==S)
            {
                sumfound = true;
                break;
            }
        }

        if (sumfound == true)
        {
            Console.WriteLine("The sum {0} is found. It is the sum of the following elements: {1}", S, str.ToString());
        }
        else
        {
            Console.WriteLine("The sum {0} is not found",S);
        }

    }

}
