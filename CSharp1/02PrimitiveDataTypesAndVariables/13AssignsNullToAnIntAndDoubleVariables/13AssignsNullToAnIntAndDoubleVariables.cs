//Create a program that assigns null values to an integer and to double variables. 
//Try to print them on the console, try to add some values or the null literal
//to them and see the result.


using System;

namespace _13AssignsNullToAnIntAndDoubleVariables
{
    class Program
    {
        static void Main()
        {
            int? integerVar = null;
            Console.WriteLine(
              "This is the integer with Null value:'{0}'" , integerVar);
            integerVar = 5;
            Console.WriteLine(
              "This is the integer with value 5: '{0}' " , integerVar);


            double? doubleVar = null;
            Console.WriteLine(
              "This is the real number with Null value :'{0}'", doubleVar);
            doubleVar = 2.5;
            Console.WriteLine(
              "This is the real number with value 2.5 :'{0}'" ,
              doubleVar);        
        }
    }
}
