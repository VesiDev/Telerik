using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a program that safely compares floating-point numbers with precision of 0.000001. 
//Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true

//bool compare = (Math.Abs(firstNumber-secondNumber) < 0.000001m);
namespace _03SafelyCompareFloatingPointNumbers
{
    class SafelyCompareFloatingPointNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Precision which need to be used is");
            Console.WriteLine("0.000001");
           // deciamal values should be rounded becase the precision should be 6 digits after the decimal point 
           
            decimal decimalvalur1 = 5.3m;
            decimal decimalvalur2 = 6.01m;
            decimal decimalvalur3 = 5.00000001m;
            decimal decimalvalur4 = 5.00000003m;
            Console.WriteLine(decimal.Round(decimalvalur3, 6));

            compareDecimal(decimalvalur1, decimalvalur2);
            compareDecimal(decimalvalur3, decimalvalur4);
        }

        private static void compareDecimal(decimal value1, decimal value2)
        {
            value1 = decimal.Round(value1, 6);
            value2 = decimal.Round(value2, 6);
            Console.WriteLine("{0} = {1} is {2}", value1, value2, value1 == value2);
        }
          
    }
}

       
    
