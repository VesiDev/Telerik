using System;

class MinimalAndMaximalFromNNumbers
{
    static void Main()
    {
        Console.WriteLine("This program reads from the console a sequence of N integer numbers and returns the minimal and maximal of them. Plees write the number of integers you  will write.");
        int N = int.Parse(Console.ReadLine());
        
        int minNum = int.Parse(Console.ReadLine());
        int maxNum = minNum;
        int currentNum;
        for (int i = 0; i < (N-1); i++)
        {
            currentNum = int.Parse(Console.ReadLine());
            if (currentNum > maxNum)
            {
                maxNum = currentNum;
            }
            if (currentNum < minNum)
            {
                minNum = currentNum;
            }
        }
        Console.WriteLine("The minimum is {0}, the maximum is {1}", minNum, maxNum);
    }
}

