using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Moje da se polzva 
//Console.WriteLine("{0}", textInfo.ToTitleCase(tenToNineteen[tempNumber]));
namespace _11.Pronunciation
{
    class Pronunciation
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 and 999 : ");
            int number = int.Parse(Console.ReadLine());
            string numberInString = Convert.ToString(number);
            string[] pronunciations = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "teen", "fifteen", "twenty", "thirty", "ty", "fifty" };
            if (number > 999)
            {
                Console.WriteLine("Enter a valid number!");
            }
            if (number <= 999)
            {
                if (number < 10)
                {
                    switch (number)
                    {
                        case 0:
                            Console.WriteLine("zero");
                            break;
                        case 1:
                            Console.WriteLine(pronunciations[0]);
                            break;
                        case 2:
                            Console.WriteLine(pronunciations[1]);
                            break;
                        case 3:
                            Console.WriteLine(pronunciations[2]);
                            break;
                        case 4:
                            Console.WriteLine(pronunciations[3]);
                            break;
                        case 5:
                            Console.WriteLine(pronunciations[4]);
                            break;
                        case 6:
                            Console.WriteLine(pronunciations[5]);
                            break;
                        case 7:
                            Console.WriteLine(pronunciations[6]);
                            break;
                        case 8:
                            Console.WriteLine(pronunciations[7]);
                            break;
                        case 9:
                            Console.WriteLine(pronunciations[8]);
                            break;

                    }
                }
                else if ((number >= 10) && (number < 20))
                {
                    switch (number)
                    {
                        case 10:
                            Console.WriteLine(pronunciations[9]);
                            break;
                        case 11:
                            Console.WriteLine(pronunciations[10]);
                            break;
                        case 12:
                            Console.WriteLine(pronunciations[11]);
                            break;
                        case 13:
                            Console.WriteLine(pronunciations[12]);
                            break;
                        case 15:
                            Console.WriteLine(pronunciations[14]);
                            break;
                        case 14:
                        case 16:
                        case 17:
                        case 18:
                        case 19:
                            if (numberInString[1] == '4')
                            {
                                Console.Write(pronunciations[3]);
                            }
                            if (numberInString[1] == '6')
                            {
                                Console.Write(pronunciations[5]);
                            }
                            if (numberInString[1] == '7')
                            {
                                Console.Write(pronunciations[6]);
                            }
                            if (numberInString[1] == '8')
                            {
                                Console.Write(pronunciations[7]);
                            }
                            if (numberInString[1] == '9')
                            {
                                Console.Write(pronunciations[8]);
                            }
                            Console.WriteLine(pronunciations[13]);
                            break;
                    }
                }
                else if ((number >= 20) && (number < 100))
                {
                    if ((numberInString[0] == '4') || (numberInString[0] == '6') || (numberInString[0] == '7') || (numberInString[0] == '8') || (numberInString[0] == '9'))
                    {
                        switch (numberInString[0])
                        {
                            case '4':
                                Console.Write(pronunciations[3]);
                                break;
                            case '6':
                                Console.Write(pronunciations[5]);
                                break;
                            case '7':
                                Console.Write(pronunciations[6]);
                                break;
                            case '8':
                                Console.Write(pronunciations[7]);
                                break;
                            case '9':
                                Console.Write(pronunciations[8]);
                                break;
                        }
                        Console.Write(pronunciations[17]);
                    }
                    else if ((numberInString[0] == '2') || (numberInString[0] == '3') || (numberInString[0] == '5'))
                    {
                        {
                            switch (numberInString[0])
                            {
                                case '2':
                                    Console.Write(pronunciations[15]);
                                    break;
                                case '3':
                                    Console.Write(pronunciations[16]);
                                    break;
                                case '5':
                                    Console.Write(pronunciations[18]);
                                    break;

                            }
                        }
                    }
                    if (numberInString[1] != '0')
                    {
                        Console.Write(" - ");
                    }
                    switch (numberInString[1])
                    {
                        case '1':
                            Console.WriteLine(pronunciations[0]);
                            break;
                        case '2':
                            Console.WriteLine(pronunciations[1]);
                            break;
                        case '3':
                            Console.WriteLine(pronunciations[2]);
                            break;
                        case '4':
                            Console.WriteLine(pronunciations[3]);
                            break;
                        case '5':
                            Console.WriteLine(pronunciations[4]);
                            break;
                        case '6':
                            Console.WriteLine(pronunciations[5]);
                            break;
                        case '7':
                            Console.WriteLine(pronunciations[6]);
                            break;
                        case '8':
                            Console.WriteLine(pronunciations[7]);
                            break;
                        case '9':
                            Console.WriteLine(pronunciations[8]);
                            break;

                    }
                }
                if (number >= 100)
                {
                    switch (numberInString[0])
                    {
                        case '1':
                            Console.Write(pronunciations[0]);
                            break;
                        case '2':
                            Console.Write(pronunciations[1]);
                            break;
                        case '3':
                            Console.Write(pronunciations[2]);
                            break;
                        case '4':
                            Console.Write(pronunciations[3]);
                            break;
                        case '5':
                            Console.Write(pronunciations[4]);
                            break;
                        case '6':
                            Console.Write(pronunciations[5]);
                            break;
                        case '7':
                            Console.Write(pronunciations[6]);
                            break;
                        case '8':
                            Console.Write(pronunciations[7]);
                            break;
                        case '9':
                            Console.Write(pronunciations[8]);
                            break;
                    }
                    Console.Write(" hundred ");
                    if ((numberInString[2] != '0') || (numberInString[1] != '0'))
                    {
                        Console.WriteLine("and ");
                    }
                    if (numberInString[1] == '1')
                    {
                        switch (numberInString[2])
                        {
                            case '0':
                                Console.WriteLine(pronunciations[9]);
                                break;
                            case '1':
                                Console.WriteLine(pronunciations[10]);
                                break;
                            case '2':
                                Console.WriteLine(pronunciations[11]);
                                break;
                            case '3':
                                Console.WriteLine(pronunciations[12]);
                                break;
                            case '5':
                                Console.WriteLine(pronunciations[14]);
                                break;
                            case '4':
                            case '6':
                            case '7':
                            case '8':
                            case '9':
                                if (numberInString[2] == '4')
                                {
                                    Console.Write(pronunciations[3]);
                                }
                                if (numberInString[2] == '6')
                                {
                                    Console.Write(pronunciations[5]);
                                }
                                if (numberInString[2] == '7')
                                {
                                    Console.Write(pronunciations[6]);
                                }
                                if (numberInString[2] == '8')
                                {
                                    Console.Write(pronunciations[7]);
                                }
                                if (numberInString[2] == '9')
                                {
                                    Console.Write(pronunciations[8]);
                                }
                                Console.WriteLine(pronunciations[13]);
                                break;
                        }
                    }
                    else
                    {

                        if ((numberInString[1] == '4') || (numberInString[1] == '6') || (numberInString[1] == '7') || (numberInString[1] == '8') || (numberInString[1] == '9'))
                        {
                            switch (numberInString[1])
                            {
                                case '4':
                                    Console.Write(pronunciations[3]);
                                    break;
                                case '6':
                                    Console.Write(pronunciations[5]);
                                    break;
                                case '7':
                                    Console.Write(pronunciations[6]);
                                    break;
                                case '8':
                                    Console.Write(pronunciations[7]);
                                    break;
                                case '9':
                                    Console.Write(pronunciations[8]);
                                    break;
                            }
                            Console.Write(pronunciations[17]);
                        }
                        else if ((numberInString[1] == '2') || (numberInString[1] == '3') || (numberInString[1] == '5'))
                        {
                            {
                                switch (numberInString[1])
                                {
                                    case '2':
                                        Console.Write(pronunciations[15]);
                                        break;
                                    case '3':
                                        Console.Write(pronunciations[16]);
                                        break;
                                    case '5':
                                        Console.Write(pronunciations[18]);
                                        break;

                                }
                            }
                        }
                        if (numberInString[2] != '0')
                        {
                            Console.Write(" - ");
                        }
                        switch (numberInString[2])
                        {
                            case '1':
                                Console.WriteLine(pronunciations[0]);
                                break;
                            case '2':
                                Console.WriteLine(pronunciations[1]);
                                break;
                            case '3':
                                Console.WriteLine(pronunciations[2]);
                                break;
                            case '4':
                                Console.WriteLine(pronunciations[3]);
                                break;
                            case '5':
                                Console.WriteLine(pronunciations[4]);
                                break;
                            case '6':
                                Console.WriteLine(pronunciations[5]);
                                break;
                            case '7':
                                Console.WriteLine(pronunciations[6]);
                                break;
                            case '8':
                                Console.WriteLine(pronunciations[7]);
                                break;
                            case '9':
                                Console.WriteLine(pronunciations[8]);
                                break;

                        }

                    }
                }

            }
        }
    }
}