using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

namespace _9PrintFirst10MembersOfSequenceChangingSign
{
    class PrintFirst10MembersOfSequenceChangingSign
    {
        static void Main(string[] args)
        {
            int number = -1;
            for (int i = 0; i < 10; i++)
            {
                if (number > 0)
                    number = -(number + 1);
                else
                    number = -(number - 1);
                Console.Write(number+" ");                
            }
            Console.WriteLine();
        }
    }
}
