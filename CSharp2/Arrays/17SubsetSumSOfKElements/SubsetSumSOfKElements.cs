//Write a program that reads three integer numbers N, K and S and an array of N elements from the console. 
//Find in the array a subset of K elements that have sum S or indicate about its absence.

using System;
using System.Text;

class SubsetSumSOfKElements
{
    static void Main()
    {
        Console.WriteLine("This program reads three integer numbers N, K and S and an array of N elements from the console and finds in the array a subset of K elements that have sum S or indicates about its absence.");
        Console.WriteLine("Please enter N, K, S and the elements of the array");
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
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
        int countOfSumed = 0;
        StringBuilder str = new StringBuilder();

        for (int num = 1; num < maxOption; num++)
        {
            sum = 0;
            countOfSumed = 0;
            str.Remove(0, str.Length);

            //chech in the binary representation of Num on which positions there are 1
            for (int position = 0; position < N; position++)
            {
                if ((num >> position & 1) == 1)
                {
                    countOfSumed++;
                    sum += arr[position];
                    str.Append(arr[position] + " ");
                }
                if (countOfSumed > K)
                {
                    break;
                }
            }

            if (countOfSumed == K && sum == S)
            {
                sumfound = true;
                break;
            }
        }

        if (sumfound == true)
        {
            Console.WriteLine("The sum {0} of {1} elements  is found. The elements are: {2}", S, K, str.ToString());
        }
        else
        {
            Console.WriteLine("The sum {0} of {1} elements  is not found", S, K);
        }
    }
}
    

