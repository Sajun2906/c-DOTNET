//Problem 1:
//You are given a square matrix of size n × n. Write a program to compute the absolute difference between the sum of its primary (left-to-right) diagonal and secondary (right-to-left) diagonal.
//Example 1:
//Matrix:
//11   2   4
// 4   5   6
//10   8 - 12
//Primary diagonal sum = 11 + 5 + (–12) = 4
//Secondary diagonal sum = 4 + 5 + 10 = 19
//Absolute difference = |19 – 4| = 15

using System;

namespace displayAnMatrix
{
    class program
    {
        static void Main()
        {
            int[,] matA = new int[3, 3];
            Console.WriteLine(" the given matrix value of 3x3 is:");
            for (int i = 0; i < matA.GetLength(0); i++)
            {
                for (int j = 0; j < matA.GetLength(1); j++)
                {
                    matA[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int pdiagonal = 0;
            Console.WriteLine("The sum of Primary diagonal:");
            for (int i = 0; i < 3; i++)
            {
                pdiagonal += matA[i, i];
            }
            Console.WriteLine(pdiagonal);

            int sdiagonal = 0;
            int a = matA.GetLength(0) - 1;

            for (int i = 0; i < matA.GetLength(0); i++)
            {
                sdiagonal += matA[i, a - i];
            }
            Console.WriteLine("Secondary Diagonal Sum: " + sdiagonal);

            int s = pdiagonal - sdiagonal;
            int difference = Math.Abs(s);
            Console.WriteLine("the difference of two diagonals are:" + difference);

        }
    }
}

