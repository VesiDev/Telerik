//Write a program that prints an isosceles triangle of 9 copyright symbols ©. 
//Use Windows Character Map to find the Unicode code of the © symbol. 
//Note: the © symbol may be displayed incorrectly.



using System;

namespace _09PrintsIsoscelesTriangle
{
    class PrintsIsoscelesTriangle
    {
        static void Main()
        {
            char copyrightSymbol = '\u00A9';
            int hight = 3;

            for (int row = 0; row < hight; row++)
            {
                for (int cell = 0; cell < (hight * 2) - 1; cell++)
                {
                    if( cell>=(hight-1-row)&&cell<=(hight-1+row))
                    {
                        Console.Write(copyrightSymbol);
                    }
                    else 
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
			

        }
    }
}
