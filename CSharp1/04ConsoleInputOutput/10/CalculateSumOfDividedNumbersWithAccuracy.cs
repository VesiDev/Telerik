//Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
using System;
//calculateSumOfDividedNumbersWithAccuracy
// Натрупвайте  сумата в променлива с цикъл и пазете старата сума, 
//докато разликата между двете суми стане по-малка от точността 
//(0.001). 


namespace _10CalculateSumOfDividedNumbersWithAccuracy
{
    class CalculateSumOfDividedNumbersWithAccuracy
    {
        static void Main(string[] args)
        {
            double previoussum = 1;
            double sum = 0;
            double sign = 0;
            Console.WriteLine(previoussum); 

            for (int i = 2; i < int.MaxValue; i++)
            {
                
                if (i % 2 == 0)
                {
                    sign = 1;
                }
                else sign = -1; 
                
                sum = previoussum + sign/i;
                double difference = sum - previoussum;
                Console.Write("{0}{1}/{2} ", ((sign==1)?"+":""), sign, i);
                if (Math.Abs(difference) < 0.001)
                {
                    Console.WriteLine("The sum is {0}. The difference between the current sum and the preious sum is {1}", sum, difference);
                    break; 
                }                
            }           
        }
    }
}

