using System;
using System.Text;


class Spiral
{
    static void Main()
    {
        Console.WriteLine("This program reads a positive integer number N (N < 20) from console and outputs in the console the numbers 1 ... N numbers arranged as a spiral.");
        Console.WriteLine("Please write a number:");        
        int n = int.Parse(Console.ReadLine());
        int curRow = 0;
        int curCol = 0;
        int step=1; 
        int[,] arr = new int[n,n];
        int outerThickness = 0;
        int row = 0;
        int col = 0;
        while(step<=n*n)
        {
            //left to right
            for (int i = outerThickness; i < n; i++)
            {
                arr[row, col] = step;
                step++;
                col++;
            }
            col--; // compensate for iteration
            row++;
            //top to bottom
            for (int i = outerThickness; i < n - 1; i++)
            {
                arr[row, col] = step;
                step++;
                row++;                
            }
            row--;
            col--;
            //right to left
            for (int i = outerThickness; i < n - 1; i++)
            {
                arr[row, col] = step;
                step++;
                col--; 
            }
            row--;
            col++;
            //bottom to top
            for (int i = outerThickness; i < n - 2; i++)
            {
                arr[row, col] = step;
                step++;
                row--;
            }
            col++;
            row++;

            // increment for outer thickness
            outerThickness += 2;
        }
        StringBuilder st = new StringBuilder();
        for (int arrow = 0; arrow < arr.GetLength(0); arrow++)
        {
            for (int arcol = 0; arcol < arr.GetLength(1); arcol++)
            {
                st.AppendFormat("{0,4}", arr[arrow, arcol]);
            }
            st.AppendLine();
        }
        Console.WriteLine(st.ToString());
    }
}
