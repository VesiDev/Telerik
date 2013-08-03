using System;

namespace _07StringAndObjectVarsToConcatStrings
{
    class Program
    {
        static void Main()
        {
            string stringVariable1 = "Hello";
            string stringVariable2 = "World";
            object objectVariable = stringVariable1 + " " + stringVariable2;
            string stringVariable3 = (string)objectVariable;

            Console.WriteLine("stringVariable1 is {0} \nstringVariable2 is {1}\nobjectVariable is {2}\nstringVariable3 is {3}", stringVariable1,stringVariable2, objectVariable, stringVariable3);
        }
    }
}
