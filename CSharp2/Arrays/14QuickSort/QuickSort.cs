//Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;
using System.Text;

class QuickSort
{
    static List<string> initialList;  
    static List<string> result = new List<string>();

    static void Main()
    {
        Console.WriteLine("This program sorts an array of strings using the quick sort algorithm");
        Console.WriteLine("Please enter the number of the elements in the array and the strings which need to be sorted.");
        int N = int.Parse(Console.ReadLine());
        string[] arr = new string[N];
        for (int i = 0; i < N; i++)
        {
            arr[i] = Console.ReadLine();            
        }
        initialList = new List<string>(arr);   
        result = Sort(initialList);
        Console.WriteLine("The sorted array is:");
        PrintList(result);
        return;
    }

    private static void PrintList(List<string> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item + " ");
        }
    }

    private static List<string> Sort(List<string> list)
    {
        if (list.Count <= 1)
        {
            return list;
        }
        else
        {
            string p = (list[list.Count/2]);
            List<string> left = new List<string>();
            List<string> right = new List<string>();
            List<string> sorted = new List<string>();
            List<string> res = new List<string>();

            for (int i = 0; i < list.Count; i++)
            {
                if (i != (list.Count / 2))
                {

                    if (String.Compare(list[i], p) <= 0)
                    {
                        left.Add(list[i]);
                    }
                    else
                    {
                        right.Add(list[i]);
                    }
                }
            }

            if (left.Count >= 1)
            {
                sorted = Sort(left);                              
            }

            sorted.Add(p);
            if (right.Count > 0)
            {
                res = Sort(right);
                foreach (var item in res)
                {
                    sorted.Add(item);
                }
            }
            return sorted;
        }
    }
}


