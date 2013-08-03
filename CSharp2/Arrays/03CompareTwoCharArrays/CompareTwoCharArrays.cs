//Write a program that compares two char arrays lexicographically (letter by letter).
////При лексикографската наредба символите се сравняват един по един 
//като се започва от най-левия. При несъвпадащи символи по-рано е 
//масивът, чийто текущ символ е по-рано в азбуката. При съвпадение 
//се продължава със следващия символ вдясно. Ако се стигне до края 
//на единия масив, по-краткият е лексикографски по-рано. Ако всички 
//съответни символи от двата масива съвпаднат, то масивите са 
//еднакви и никой о тях не е по-рано в лексикографската наредба.

using System;

class CompareTwoCharArrays
{
    static void Main()
    {
        Console.WriteLine("This program compares two char arrays lexicographically (letter by letter).\nPlease enter the first string");
        string firstStr = Console.ReadLine();
        Console.WriteLine("Please enter the second string");
        string secondStr = Console.ReadLine();
       
        bool areArraysEqual = true;
        string earlierLexicographically = "";

        if (firstStr.Length != secondStr.Length)
        {
            if(firstStr.Length<secondStr.Length)
            {
                 earlierLexicographically = firstStr;
                 areArraysEqual = false;
            }
            else
            {
                 earlierLexicographically = secondStr;
                 areArraysEqual = false;
            }
        }  

        //firstStr.Length==secondStr.Length
        else 
        {
            for (int i = (firstStr.Length-1); i>-1; i--)
            {
                if (firstStr[i]<secondStr[i])
                {
                    earlierLexicographically = firstStr;
                    areArraysEqual = false;
                    break;
                }
                else if (firstStr[i] > secondStr[i])
                {
                    earlierLexicographically = secondStr;
                    areArraysEqual = false;
                    break;
                }
                //firstStr[i]==secondStr[i]
                else
                {
                    continue;
                }
            }
        }

        if (areArraysEqual == false)
        {
            Console.WriteLine("{0} is earlier lexicographically", earlierLexicographically);
        }
        else
        {
            Console.WriteLine("Arrays are equal");
        }
    }
}