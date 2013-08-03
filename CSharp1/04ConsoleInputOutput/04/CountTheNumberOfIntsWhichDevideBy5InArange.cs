//Write a program that reads two positive integer numbers and 
//prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.


using System;

namespace _04
{
    class CountTheNumberOfIntsWhichDevideBy5InArange
    {
        static void Main()
        {
                    
            Console.WriteLine("Please write the first number");
            uint uint1 = uint.Parse(Console.ReadLine());
            Console.WriteLine("Please write the second number");
            uint uint2 = uint.Parse(Console.ReadLine());
           
            int p = 0;
            if (uint1 > uint2)
            {
                uint swift = uint1;
                uint1 = uint2;
                uint2 = swift; 
            }
            Console.WriteLine("{0} {1}", uint1, uint2);
            for (uint i= uint1; i < uint2; i++)
            {
                if (i % 5 == 0)
                {
                    p++;
                }
            }

            Console.WriteLine("The number of numbers p between {0} and {1} (inclusive) for which the reminder of the division by 5 is {2} .", uint1, uint2, p);
        }
    }
}
