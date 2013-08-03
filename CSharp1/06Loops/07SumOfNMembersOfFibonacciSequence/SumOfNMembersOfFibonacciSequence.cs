using System;

class SumOfNMembersOfFibonacciSequence
{
    static void Main()
    {
        Console.WriteLine("This program reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377,...");
        Console.WriteLine("0 will be considered as the first member. Please write a number");
        int n = int.Parse(Console.ReadLine());
        int sum=0; 
        
        if (n > 1)
        {
            int previousNum = 0;
            int Num = 1;
            int NextNum = previousNum + Num;
            sum = previousNum + Num;

            for (int i = 3; i <= n; i++)
            {
                NextNum = previousNum + Num;
                previousNum = Num;
                Num = NextNum;
                sum = sum + NextNum;
            }
        }
        Console.WriteLine("The sum of first {0} members of the sequence of Fibonacci  is {1}", n, sum);
    }
}

