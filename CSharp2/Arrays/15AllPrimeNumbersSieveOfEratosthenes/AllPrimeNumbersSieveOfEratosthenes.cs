using System;
using System.Text;

class AllPrimeNumbersSieveOfEratosthenes
{
    static void Main()
    {
        int n = 10000000;
        bool[] arr = new bool[n];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = true;
        }

        for (int i = 2; i < arr.Length; i++)
        {
            if (arr[i] == true)
            {
                for (int j = i + i; j < arr.Length; j += i)
                {
                    arr[j] = false;
                }
            }
        }
        Console.WriteLine("All the prime numbers in the range 1 - 10 000 000 are");
        StringBuilder str = new StringBuilder();
        for (int i = 2; i < arr.Length; i++)
        {
            if (arr[i] == true)
            {
                str.Append(i + " ");
            }
        }
        Console.WriteLine(str.ToString());
    }
}
