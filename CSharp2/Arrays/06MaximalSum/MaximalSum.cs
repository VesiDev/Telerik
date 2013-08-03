//Write a program that reads two integer numbers N and K and 
//an array of N elements from the console. 
//Find in the array those K elements that have maximal sum.

using System;
using System.Text;

class MaximalSum
{
    static void Main()
    {
        Console.WriteLine("This program reads two integer numbers N, K and an array of N elements");
        Console.WriteLine("and find in the array those K elements that have maximal sum.");
        Console.WriteLine("Please enter N and K and the elements of the array");
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        if (N <= 1)
        {
            Console.WriteLine("N should be greater than 1");
            return; //return exits main metod
        }
        if ((K > N)&&(K<1))
        {
            Console.WriteLine("K should be smaller than N and greater than 1");
            return;
        }

        int[] arr = new int[N];
        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }        
        //N elements binary representation  - > Math.Pow(2,K)-1
        int maxOption = (int)Math.Pow(2, N);// if N = 5 elements  11111 = 31 i.e Pow(2,5)-1
        int maxSum = int.MinValue;
        int sum = 0;
        bool check = true;
        int counter = 0;
        StringBuilder str = new StringBuilder();
        StringBuilder maxSumElements = new StringBuilder();
        for (int num = 1; num < maxOption; num++)
        {
            str = new StringBuilder();
            sum = 0;
            counter = 0;
            check = false;
            int possibleSum=0;
            string possileElements=""; 
            //chech in the binary representation of Num on which positions there are 1
            for (int position = 0; position < N; position++)
            {                
                if ((num >> position & 1) == 1)
                {
                    counter++; //if 1 is found at current possition counter is incremented                    
                   
                    if (counter > K)
                    {
                        check = false;
                        break;  //If counter is > K, break the for loop and start checking the next num 
                    }
                    else
                    {
                        sum += arr[position];
                        str.Append(arr[position] + " ");
                        if (counter == K)
                        {
                            check = true;
                            possibleSum = sum;
                            possileElements = str.ToString();
                        }
                    }
                }
            }

            if (check == true && possibleSum > maxSum)
            {
                maxSum = possibleSum;
                maxSumElements = new StringBuilder();
                maxSumElements.Append(possileElements);
            }
        }
        Console.WriteLine("The max sum is {0} and consist of the following elements: {1}", maxSum,maxSumElements.ToString());
    }
}

