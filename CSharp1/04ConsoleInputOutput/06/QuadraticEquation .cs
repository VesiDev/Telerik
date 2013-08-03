//Write a program that reads the coefficients a, b and c of a quadratic equation 
//ax2+bx+c=0 and solves it (prdoubles its real roots).
//Квадратното уравнение има следния вид: ax2 + bx + c = 0
//където a,b,c са реални числа, и a ≠ 0. 
//Всяко квадратно уравнение може да има 0, 1 или 2 реални корена
 //получени по следната формула: 
//x=-b+(korenkvadraten ot) 
//Числото D = b2 - 4ac се нарича дискриминанта.
//Ako D < 0, квадратното уравнение няма реални корени. Ako D = 0, уравнението има 1 реален корен x = - b/2a. Ako D > 0, квадратното уравнение има 2 реални корена.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please write the coefficients a");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Please write the coefficients b");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Please write the coefficients c");
        int c = int.Parse(Console.ReadLine());
        int d = (b*b-4*a*c);            
        if ((a == 0)||(d<0))
        {
            System.Console.WriteLine("The equation does not have real roots.");
        }
        else
        { 
            if(d==0)
            {
                Console.WriteLine("The equation has one double root {0}", -b/2*a);
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
      