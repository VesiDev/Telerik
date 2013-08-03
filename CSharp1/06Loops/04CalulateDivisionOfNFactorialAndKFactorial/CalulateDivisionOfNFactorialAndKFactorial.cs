using System;

//3! = 1*2*3=6
//5! = 1*2*3*4*5=120
//3! = 1*2*3       6      1          1
//------------  =  --  = --- = ---------------- =1/20=0.05
//5! = 1*2*3*4*5   120   4*5  (n+1)*(n+2)*...*k

class CalulateDivisionOfNFactorialAndKFactorial
{
    static void Main()
    {
        Console.WriteLine("This program calculates N!/K! for given N and K (1<N<K).");
        Console.WriteLine("Please write N and K:");
        double divider = 1.0;
        double result = 1.0; 
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        if (N>K)
        {
            int swift = K;
            K = N;
            N = swift; 
        }
        for (int i = N+1; i <=K; i++)
        {
            divider = divider * i;
        }
        result = 1 / divider;
        Console.WriteLine("{0}!/{1}! = {2}", N, K, result);
    }
}

