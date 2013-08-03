using System;
using System.Text;
 
class CodePage437
{
    public static void Main(string[] args)
    {
 
        // Get rid of the scroll bars by making the buffer the same size as the window
        Console.Clear();
        Console.SetWindowSize(65, 33);
        Console.BufferWidth = 65;
        Console.BufferHeight = 33;
 
        // Set the window size and title
        Console.Title = "Code Page 437: MS-DOS ASCII Characters";
 
        for (byte b = 0; b < byte.MaxValue; b++)
        {
            char c = Encoding.GetEncoding(437).GetChars(new byte[] { b })[0];
            switch (b)
            {
                case 8: // Backspace
                case 9: // Tab
                case 10: // Line feed
                case 13: // Carriage return
                    c = '.';
                    break;
            }
 
            Console.Write("{0:000} {1}   ", b, c);
 
            // 7 is a beep -- Console.Beep() also works
            if (b == 7) Console.Write(" ");
 
            if ((b + 1) % 8 == 0)
                Console.WriteLine();
        }
        Console.WriteLine();
 
    }
}

 
//using System;
//using System.Text;

//namespace _12PrintASCIITable
//{
//    class PrintASCIITable
//    {
//        static void Main()
//        {                   
           
//                Console.OutputEncoding = System.Text.Encoding.GetEncoding(1252);
//                for (int i = 0; i <= 255; i++)
//                {
//                    Console.WriteLine("ASCII symbol number " + i + " is " + (char)i);
//                }             

//        }
//    }
//}
        
