//Write a program that enters the coefficients a, b and c of a quadratic equation
//a*x2 + b*x + c = 0
//and calculates and prints its real roots. 
//Note that quadratic equations may have 0, 1 or 2 real roots.


using System;

class CalculateRealRootsOfQuadrEquation
{
    static void Main()
    {
        Console.WriteLine("Please write the coefficients a");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Please write the coefficients b");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Please write the coefficients c");
        int c = int.Parse(Console.ReadLine());
        int d = (b * b - 4 * a * c);
        if ((a == 0) || (d < 0))
        {
            System.Console.WriteLine("The equation does not have real roots.");
        }
        else
        {
            if (d == 0)
            {
                Console.WriteLine("The equation has one double root {0}", -b / 2 * a);
            }
            else
            {
                double firtstRoot = (-b + Math.Sqrt(d)) / (2 * a);
                double secondRoot = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("The first root is {0} and the second root is {1}", firtstRoot, secondRoot);
            }
        }
    }
}
 
