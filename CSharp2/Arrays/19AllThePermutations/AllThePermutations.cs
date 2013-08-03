//Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. Example:
//n = 3 -> {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}

using System;

class AllThePermutations
{
    static void Main()
    {
        Console.WriteLine("This program reads a number N and generates and prints all the permutations of the numbers [1 … N]");
        Console.WriteLine("Please enter N:");
        int N = int.Parse(Console.ReadLine());
        int[] arr = new int[N];
        int swap;
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i + 1;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                foreach (var item in arr)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
                swap = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = swap;
            }
        }
    }
}