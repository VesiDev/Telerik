using System;

namespace _06BooleanVarRepresentingGender
{
    class Program
    {
        static void Main()
        {
           bool isFemale;
           char gender;
           Console.WriteLine("Please specify your gender.Please write 'f' for female and 'm' for male");
           char.TryParse(Console.ReadLine(), out gender);
            if (gender == 'f')
            {
                isFemale = true;
                Console.WriteLine("You are a female");
            }
            else if (gender == 'm')
            {
                isFemale = false;
                Console.WriteLine("You are a male");
            }
            else
                Console.WriteLine("Invalid input");
        }
    }
}
