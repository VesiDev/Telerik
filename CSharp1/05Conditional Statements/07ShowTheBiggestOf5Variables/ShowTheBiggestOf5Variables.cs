using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace _09.IsSumZero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your 5 ints.");
            int[] givenInts = new int[5];
            for (int i = 0; i < 5; i++)
            {
                givenInts[i] = int.Parse(Console.ReadLine());
            }
            if (givenInts[0] + givenInts[1] == 0)
            {
                Console.WriteLine("0");
            }
            if (givenInts[1] + givenInts[2] == 0)
            {
                Console.WriteLine("0");
            }
            if (givenInts[2] + givenInts[3] == 0)
            {
                Console.WriteLine("0");
            }
            if (givenInts[3] + givenInts[4] == 0)
            {
                Console.WriteLine("0");
            }
            if (givenInts[0] + givenInts[2] == 0)
            {
                Console.WriteLine("0");
            }
            if (givenInts[0] + givenInts[3] == 0)
            {
                Console.WriteLine("0");
            }
            if (givenInts[0] + givenInts[4] == 0)
            {
                Console.WriteLine("0");
            }
            if (givenInts[1] + givenInts[3] == 0)
            {
                Console.WriteLine("0");
            } if (givenInts[1] + givenInts[4] == 0)
            {
                Console.WriteLine("0");
            }
            if (givenInts[2] + givenInts[4] == 0)
            {
                Console.WriteLine("0");
            }
            int a = 1;

            for (int i = 0; i < 5; i++)
            {
                for (int b = 0; b < 5; b++)
                {
                    for (int c = 0; c < 5; c++)
                    {
                        if (givenInts[i] + givenInts[b] + givenInts[c] == 0)
                        {
                            a = 0;
                            Console.WriteLine();
                            Console.WriteLine(a);
                            break;

                        }
                    }
                    if (a == 0)
                    {
                        break;
                    }
                }

                if (a == 0)
                {
                    break;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int b = 0; b < 5; b++)
                {
                    for (int c = 0; c < 5; c++)
                    {
                        for (int d = 0; d < 5; d++)
                        {
                            if (givenInts[i] + givenInts[b] + givenInts[c] + givenInts[d] == 0)
                            {
                                a = 0;
                                Console.WriteLine();
                                Console.WriteLine(a);
                                break;

                            }
                        }
                        if (a == 0)
                        {
                            break;
                        }

                    }
                    if (a == 0)
                    {
                        break;
                    }
                }

                if (a == 0)
                {
                    break;
                }
            }
        }
    }
}
