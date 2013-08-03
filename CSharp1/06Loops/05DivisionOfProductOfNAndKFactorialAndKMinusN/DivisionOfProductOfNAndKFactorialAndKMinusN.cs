using System;

class DivisionOfProductOfNAndKFactorialAndKMinusN
{
    static void Main()
    {       
        Console.WriteLine("This program calculates N!*K! / (K-N)! for given N and K (1<N<K)");
        Console.WriteLine("Please write N and K: ");
        
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        if (N > K)
        {
            int swift = K;
            K = N;
            N = swift;
        }
        int product = 1;
        int divisor = 1; 
        for (int i = 1; i <= N; i++)
        {
            product = product *i*i;
        }
        for (int i = N + 1; i <= K; i++)
        {
            product = product * i;
        }
        for (int i = 1; i <= (K-N); i++)
        {
            divisor = divisor * i;
        }
        double result = product / divisor; 
        Console.WriteLine("{0}!*{1}!/({1}-{0})! = {2}", N, K, result);
    }
}

