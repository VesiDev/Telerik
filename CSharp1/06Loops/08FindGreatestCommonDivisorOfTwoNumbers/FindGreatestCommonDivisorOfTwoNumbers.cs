using System;

//1) За делимо се взима по-голямото число, а за делител - по-малкото число.  
//2) Делителя от предишната стъпка се разделя на получения остатък.  
//3) Това се повтаря дотогава, докато получим остатък 0. 
//   Този делител, при който частното няма остатък е НОД.
 //примерът НОД(18,84) 
 //84/18 = 4 и остатък 12
 //18/12 = 1 и остатък 6
 //12/6 = 2 без остатък
 //=> НОД(18,84) = 6

class FindGreatestCommonDivisorOfTwoNumbers
{
    static void Main()
    {
        Console.WriteLine("This program calculates the greatest common divisor (GCD) of two numbers, using the Euclidean algorithm");
        int biggerNumber = int.Parse(Console.ReadLine());
        int smallerNumber = int.Parse(Console.ReadLine());
        if (biggerNumber < smallerNumber)
        {
            int swift = biggerNumber;
            biggerNumber = smallerNumber;
            smallerNumber = swift; 
        }
        
        int  divident = biggerNumber;
        int divisor = smallerNumber;
        int remaining;
        int gcd = 1;
       
        do
        {
            remaining = divident % divisor;
            if (remaining == 0)
            {
                gcd = divisor;
            }
            else
            {
                divident = divisor;
                divisor = remaining;
            }
        }
        while (remaining != 0);
        
        Console.WriteLine("The greatest common divisor (GCD) of {0} and {1} is {2}", biggerNumber, smallerNumber, gcd);
    
    }
}

