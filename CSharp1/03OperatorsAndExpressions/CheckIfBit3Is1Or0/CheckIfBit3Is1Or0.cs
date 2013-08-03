//Write a boolean expression for finding if the bit 3 (counting from 0) 
//of a given integer is 1 or 0.


using System;

namespace _05CheckIfBit3Is1Or0
{
    class Program
    {
        static void Main()
        {
            //get bit at position p in a number n
            int targetBitPosition = 3;
            Console.WriteLine("Please write an number in its bit representation");
            try 
	        {                
                int number = Convert.ToInt32(Console.ReadLine(), 2);
                Console.WriteLine(number);
                int mask = 1 << targetBitPosition;        // 00000000 00001000
                int nAndMask = number & mask;             
                int bit = nAndMask >> targetBitPosition;
                Console.WriteLine("The bit at position {0} (counting from 0)  is {1}", targetBitPosition, bit);                
            }
	        catch (Exception)
	        {
                Console.WriteLine("Invalid imput.");
	        }          
           
        }
    }
}
