using System;
using System.Collections;
using System.Threading;

namespace _11FallingRocks
{
    class Program
    {
        static void Main()
        {

            int rows = 8;
            int columns = 20;
            int dwarfXCoord = 9;
            int dwarfValue = 0;
            char[,] originalArray = new char[rows, columns];
            ConsoleColor[,] originalColorArray = new ConsoleColor[rows, columns];
            InicializeArray(originalArray);
            InicializeColorArray(originalColorArray);
            int currentRow = 0;
            int lastRow = rows;
            int scoreCounter = 0;
            Thread.Sleep(300);
            
            while (true)
            {
                
                 dwarfXCoord = CheckDwarfPosition(columns, dwarfXCoord);
                 currentRow = PrintFallingRocksOnConsole(rows, columns, originalArray, originalColorArray, currentRow, dwarfXCoord);
                 if (currentRow == -1)
                 {
                     Console.WriteLine("Game over. Your score is {0}", scoreCounter);
                     break;  
                 }
                 else
                 {
                     scoreCounter++;
                 }
            }
        }

        private static int CheckDwarfPosition(int columns, int dwarfXCoord)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarfXCoord - 1 >= 1)
                    {
                        dwarfXCoord--;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (dwarfXCoord + 1 < columns - 1)
                    {
                        dwarfXCoord++;
                    }
                }
            }
            return dwarfXCoord;
        }

        private static int  PrintFallingRocksOnConsole(int rows, int columns, char[,] originalArray, ConsoleColor[,] originalColorArray, int currentRow, int dwarfXCoord )
        {
            for (int i = 0; i < rows; i++)
            {
                for (int column = 0; column < columns; column++)
                {
                    if (i != (rows - 1))
                    {
                        Console.ForegroundColor = originalColorArray[currentRow, column];                        
                        Console.Write(originalArray[currentRow, column]);
                    }
                    else
                    {
                        if (column == (dwarfXCoord - 1))
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("(0)"); 
                            column++; 
                            if(originalArray[currentRow,column]!=' ')
                            {
                                Console.WriteLine("Crash!");
                                return -1; 
                            }
                            else 
                            {
                                column = column + 1;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = originalColorArray[currentRow, column];                           
                            Console.Write(originalArray[currentRow, column]);
                        }
                    }
                }
                Console.WriteLine();

                if (i == (rows - 1))
                {
                    Thread.Sleep(500);
                    Console.Clear();
                }
                else if (currentRow == (rows - 1))
                {
                    currentRow = 0;
                }
                else
                {
                    currentRow++;
                }
            }
            Console.Clear();             
            return currentRow; 
        }
  
        private static void InicializeArray(char[,] originalArray)
        {
            char currentChar;
            Random number = new Random();  
            for (int row = 0; row < originalArray.GetLength(0); row++)
            {
                for (int column = 0; column < originalArray.GetLength(1); column++)
                {
                    currentChar = SetChar(number.Next(130));
                    originalArray[row, column] = currentChar;
                }
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
        //Console colours from 0 black to 15 White       
        private static void InicializeColorArray(ConsoleColor[,] originalColorArray)
        {
            Random colour = new Random(7);
            for (int row = 0; row < originalColorArray.GetLength(0); row++)
            {
                for (int column = 0; column < originalColorArray.GetLength(1); column++)
                {
                    originalColorArray[row, column] = (ConsoleColor)colour.Next(1, 15);
                }
            }
        }

    }
}
