//Write a program that creates an array containing all letters from the alphabet (A-Z). 
//Read a word from the console and print the index of each of its letters in the array
using System;

namespace _12IndexOfLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program creates an array containing all letters from the alphabet (A-Z) and reads a word from the console and print the index of each of its letters in the array");
            char[] alphabethArr = new char[52];
            char letter = 'A';
            for (int i = 0; i < 26; i++) //A-Z  65- 90 = 26 elements
            {
                alphabethArr[i] = (char)(letter + i);
            }
            letter = 'a';
            for (int i = 0; i < 26; i++) //a-z  97- 122 = 26 elements 
            {
                alphabethArr[i + 26] = (char)(letter + i);
            }
           
            Console.WriteLine("Please write a word");
            string str = Console.ReadLine();
            char searchedEl;
            for (int i = 0; i < str.Length; i++)
            {
                searchedEl = str[i];
                bool isElemInArr = true;
                int searchedIndex = -1;
                int minValue = 0;
                int maxValue = 51;
                int mid;


                while (true)
                {
                    if (searchedEl >  alphabethArr[maxValue] || searchedEl <  alphabethArr[minValue])
                    {
                        isElemInArr = false;
                        break;
                    }
                    else
                    {
                        isElemInArr = true;
                        mid = minValue + (maxValue - minValue) / 2;
                        
                        
                        if ( alphabethArr[mid] > searchedEl)
                        {
                            maxValue = mid-1;
                        }
                        else if (alphabethArr[mid] < searchedEl)
                        {
                           minValue = mid+1;
                        }
                        else
                        {
                            searchedIndex = mid;
                            break; 
                        }                       
                    }
                }
                if (isElemInArr == false)
                {
                    Console.WriteLine("Element {0} is not in the array", searchedEl);
                }
                else
                {
                    Console.WriteLine("Element {0} has index {1}", searchedEl, searchedIndex);
                }
            }
        }
    }
}
