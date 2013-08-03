using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {            
            char[,] originalArray = new char[8, 20];
            char currentChar;
            Random number = new Random();           

            for (int row = 0; row < originalArray.GetLength(0); row++)
            {
                for (int column = 0; column < originalArray.GetLength(1); column++)
                {                    
                    currentChar = SetChar(number.Next(1, 150));
                    originalArray[row, column] = currentChar;
                }
            }

            for (int row = 0; row < originalArray.GetLength(0); row++)
            {
                for (int column = 0; column < originalArray.GetLength(1); column++)
                {
                    Console.Write(originalArray[row, column]);
                }
                Console.WriteLine();
            }
        }

        private static char SetChar(int number)
        {
            char character;
            switch (number)
            {
                case 1: character = '^'; break;
                case 2: character = '@'; break;
                case 3: character = '*'; break;
                case 4: character = '&'; break;
                case 5: character = '+'; break;
                case 6: character = '%'; break;
                case 7: character = '$'; break;
                case 8: character = '#'; break;
                case 9: character = '!'; break;
                case 10: character = '.'; break;
                case 11: character = ';'; break;
                default: character = ' '; break;
            }
            return character;
        }
    }
}
