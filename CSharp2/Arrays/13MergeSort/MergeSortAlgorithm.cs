//Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;

class MergeSortAlgorithm
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program sorts an array of integers using the merge sort algorithm");
        List<int> initList = new List<int>();
        Random rand = new Random();
        for (int i = 0; i < 100; i++)
        {

            initList.Add(rand.Next(0, 1999));

        }
        Console.WriteLine("Initial array");
        foreach (int item in initList)
        {
            Console.Write("{0,-5}", item);
        }
        initList = MergeSort(initList);
        Console.WriteLine();
        Console.WriteLine("\nSorted array");
        foreach (int item in initList)
        {
            Console.Write("{0,-5}", item);
        }
    }

    public static List<int> MergeSort(List<int> list)
    {
        if (list.Count > 1)
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (i < (list.Count / 2))
                {
                    list1.Add(list[i]);
                }
                else
                {
                    list2.Add(list[i]);
                }
            }
            list1 = MergeSort(list1);
            list2 = MergeSort(list2);
            return Merge(list1, list2);
        }
        else
        {
            return list;
        }
    }

    private static List<int> Merge(List<int> list1, List<int> list2)
    {
        List<int> resultList = new List<int>();
        int currElementInList1 = 0;
        int currElementInList2 = 0;
        int lastElInList1 = (list1.Count - 1);
        int lastElInList2 = (list2.Count - 1);
        while (currElementInList1 <= lastElInList1 || currElementInList2 <= lastElInList2)
        {
            if ((list2.Count == currElementInList2) || (currElementInList1 <= lastElInList1 && (list1[currElementInList1] <= list2[currElementInList2])))
            {
                resultList.Add(list1[currElementInList1]);
                currElementInList1++;
            }
            else
            {
                if ((list1.Count == currElementInList1) || (currElementInList2 <= lastElInList2 && (list1[currElementInList1] > list2[currElementInList2])))
                {
                    resultList.Add(list2[currElementInList2]);
                    currElementInList2++;
                }
            }
        }
        return resultList;
    }
}
    