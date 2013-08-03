//Sort 3 real values in descending order using nested if statements.
//10, 9, 8
using System;


class Sort3RealValuesInDescendingOrder
{
    static void Main()
    {
        Console.WriteLine("This program  Sort 3 real values in descending order using nested if statements");
        Console.WriteLine("Write a three real numbers.");
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double thirdNum = double.Parse(Console.ReadLine());

        double swift;

        for (int i = 1; i < 3; i++)
        {
            if ((firstNum - secondNum) < 0.00001)
            {
                swift = firstNum;
                firstNum = secondNum;
                secondNum = swift;
            }
            if ((secondNum - thirdNum) < 0.00001)
            {
                swift = secondNum;
                secondNum = thirdNum;
                thirdNum = swift;
            }
        }
        Console.WriteLine("{0}, {1}, {2}", firstNum, secondNum, thirdNum);
    }
}


