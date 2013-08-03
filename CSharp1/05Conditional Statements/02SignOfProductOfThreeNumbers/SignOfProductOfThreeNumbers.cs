//Write a program that shows the sign of the product of three real numbers without calculating it. 
//Use a sequence of if statements.

using System;


class SignOfProductOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("This program  shows the sign of the product of three real numbers without calculating it.");
        Console.WriteLine("Write three real numbers.");
        int sumOfNegativSigns = 0;
        bool zero =false;

        for (int i = 0; i < 3; i++)
        {
            double number  = double.Parse(Console.ReadLine());
            if (number == 0)
            {                 
                zero = true; 
                break; 
            }
            else if(number<0)
            {
                sumOfNegativSigns++;
            }
        }

        if(zero==true)
        {
            Console.WriteLine("The product is 0");
        }
        else if(sumOfNegativSigns==0)
        {
           Console.WriteLine("The sign of the product is +"); 
        }
        else if(sumOfNegativSigns%2==0)
        {
           Console.WriteLine("The sign of the product is +"); 
        }
        else
        {
            Console.WriteLine("The sign of the product is -"); 
        }   
    }
}
