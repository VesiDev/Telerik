//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}	
using System;
using System.Text;

class SequenceOfGivenSum
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program reads two integer numbers N and S and an array of N elements");
        Console.WriteLine("and finds sum S (if present).");
        Console.WriteLine("Please enter N and S and the elements of the array");
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
        bool oneFound = false; 
        bool sumFound = false;
        StringBuilder str = new StringBuilder();
        

        for (int num = 1; num < maxOption; num++)
        {
            sum = 0;           
            str = new StringBuilder();
            oneFound = false; 
            //chech in the binary representation of Num on which positions there are 1
            for (int position = 0; position < N; position++)
            {
                if ((num >> position & 1) == 1)
                {
                    oneFound = true; 
                    sum += arr[position];
                    str.Append(arr[position] + " ");
                }
                else
                {
                    if (oneFound==true)
                    {
                        break;                    
                    }
                }
            }

            if (sum == S)
            {                
                sumFound = true;
                break; 
            }
        }
        if (sumFound == false)
        {
            Console.WriteLine("The sum is not found");
        }
        else
        {
            Console.WriteLine("The sum {0} is found: {1}", S, str.ToString());
        }
    }
}