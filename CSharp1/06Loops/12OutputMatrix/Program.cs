

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a positive integer number N (N<20) and the program will outputs a matrix");
        uint n; 
        bool isSuccessful=uint.TryParse(Console.ReadLine(), out n);
        if (isSuccessful == true && (n < 20))
        {
            int value;
            for (int i = 1; i <= n; i++)
            {
                value = i;
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("{0,3}", value);
                    value++;
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid imput");
        }
    }
}
   
