using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//* Write a program to read your age from the console and print how old you will be after 10 years.

namespace _12ReadAndWriteYourAgeAfter10Years
{
    class ReadAndWriteYourAgeAfter10Years
    {
        static void Main(string[] args)
        {
            string input;
            byte age;
            Console.WriteLine("Please write your age: ");
            input = Console.ReadLine();
            if( byte.TryParse(input, out age)&&age<120)
            {
                Console.WriteLine("You will be {0} years old after {1} years ", age+10, 10);            
            }
            else 
            {
                Console.WriteLine("You have entered incorrect value.");
            }            
        }
    }
}
