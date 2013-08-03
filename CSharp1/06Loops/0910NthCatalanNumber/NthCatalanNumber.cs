using System;
//http://mathforum.org/mathimages/index.php/Catalan_Numbers
class NthCatalanNumber
{
    static void Main()
    {
        Console.WriteLine("This program calculates the Nth Catalan number by given N. Please enter N:");
        int N = int.Parse(Console.ReadLine());
        double num = 1; 
        for (int i = 2; i <=N; i++)
        {
            num = num * (N + i) / i;
        }
        Console.WriteLine("Nth Catalan number is {0}", num);
    }
}

