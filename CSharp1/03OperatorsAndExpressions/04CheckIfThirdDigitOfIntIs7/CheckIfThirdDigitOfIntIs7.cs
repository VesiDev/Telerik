//Write an expression that checks for given integer if its third digit (right-to-left) is 7.
//E. g. 1732 -> true.


using System;

namespace _04CheckIfThirdDigitOfIntIs7
{
    class CheckIfThirdDigitOfIntIs7
    {
        static void Main()
        {
            int valueToCheck; 
            Console.WriteLine("This program checks for given integer if its third digit (right-to-left) is 7.");
            Console.WriteLine("Please enter an integer which has at least 3 digits");
            if (int.TryParse(Console.ReadLine(), out valueToCheck) == true && ((valueToCheck/=100) > 0))
            {
                Console.WriteLine(valueToCheck);
                if((valueToCheck % 10)==7)
                    Console.WriteLine("The third digit (right-to-left) is 7.");                    
                else
                    Console.WriteLine("The third digit (right-to-left) is Not 7.");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
