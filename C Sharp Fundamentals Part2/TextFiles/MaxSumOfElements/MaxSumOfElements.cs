/*
 * Write a program that reads a text file containing a square matrix 
 * of numbers and finds in the matrix an area of size 2 x 2 with a 
 * maximal sum of its elements. The first line in the input file 
 * contains the size of matrix N. Each of the next N lines contain N 
 * numbers separated by space. The output should be a single number 
 * in a separate text file. Example:
    4
    2 3 3 4
    0 2 3 4			17
    3 7 1 2
    4 3 3 2
 */

using System;
using System.IO;

class MaxSumOfElements
{
    static void Main(string[] args)
    {
        int[,] arr = ReadFile("..//..//matrix.txt");

        //Console.WriteLine(GetMaxSum(arr));

        int maxSum = GetMaxSum(arr);

        WriteFile(maxSum, "..//..//MaxSum.txt");
    }

    static void WriteFile(int maxSum, string filename)
    {
        StreamWriter writer = new StreamWriter(filename);
        try
        {
            using (writer)
            {
                writer.WriteLine(maxSum);
                writer.Flush();
            }
        }
        catch (FileNotFoundException fe)
        {
            Console.WriteLine(fe.Message);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
    }

    static int[,] ReadFile(string filename)
    {
        int[,] matrix = null;
        try
        {
            StreamReader reader = new StreamReader(filename);
            using (reader)
            {
                string line = reader.ReadLine();
                int dimension = 0;
                int counter = 0;
                while (line != null)
                {
                    if (line.Length == 1)
                    {
                        dimension = int.Parse(line);
                        matrix = new int[dimension, dimension];
                    }
                    else
                    {
                        string newLine = line.Replace(" ", "");
                        for (int i = 0; i < newLine.Length; i++)
                        {

                            matrix[counter, i] = int.Parse(newLine[i].ToString());
                        }
                        counter++;
                    }
                    line = reader.ReadLine();
                }
            }
        }
        catch (FileNotFoundException fe)
        {
            Console.WriteLine(fe.Message);
        }
        catch (ArgumentOutOfRangeException aor)
        {
            Console.WriteLine(aor.Message);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
        return matrix;
    }

    static int GetMaxSum(int[,] matrix)
    {
        int bestSum = int.MinValue;
        //int bestRow = 0;
        //int bestCol = 0;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] +
                          matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    //bestRow = row;
                    //bestCol = col;
                }
            }
        }
        return bestSum;
    }
}