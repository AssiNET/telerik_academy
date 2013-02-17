using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1_FillAndPrintMatrix
{
    class Problem1_FillAndPrintMatrix
    {
        static int[,] matrix;

        static void Print(int[,] arr, int n)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0, 4}", arr[row, col]);
                }
                Console.WriteLine("\n");
            }
        }

        static void OptionAFillByColumns(int n)
        {
            Console.WriteLine("A)\n");
            int counter = 0;
            matrix = new int[n, n];

            //Moving DOWN
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    counter++;
                    matrix[row, col] = counter;
                }
            }
            Print(matrix, n);
        }

        static void OptionBUpAndDown(int n)
        {
            Console.WriteLine("B)\n");
            int counter = 0;
            int startRow = 0;
            int startCol = 0;            

            matrix = new int[n, n];

            while (counter < n*n)
            {
                //Moving DOWN
                for (int rowNum = startRow; rowNum <= n - 1; rowNum++)
                {
                    counter++;
                    matrix[rowNum, startCol] = counter;
                }
                startCol++;

                //Moving UP
                for (int rowNum = n - 1; rowNum >= 0; rowNum--)
                {
                    counter++;
                    matrix[rowNum, startCol] = counter;
                }
                startCol++;
            }
            Print(matrix, n);
        }

        static void OptionCFillHorizontally(int n)
        {
            Console.WriteLine("C)\n");
            int counter = 1;
            
            //First Half
            for (int rowNum = 0; rowNum <= n - 1; rowNum++)
            {
                for (int colNum = 0; colNum <= rowNum; colNum++)
                {
                    matrix[n - rowNum + colNum - 1, colNum] = counter;
                    counter++;
                }
            }

            //Second Half
            for (int rowNum = n - 2; rowNum >= 0; rowNum--)
            {
                for (int colNum = rowNum; colNum >= 0; colNum--)
                {
                    matrix[rowNum - colNum, n - colNum - 1] = counter;
                    counter++;
                }
            }

            Print(matrix, n);
        }

        static void OptionDFillBySpiral(int n)
        {
            Console.WriteLine("D)\n");
            int counter = 0;
            matrix = new int[n, n];
            int startRow = 0;
            int endRow = n - 1;
            int startCol = 0;
            int endCol = n - 1;

            while (counter < n * n)
            {
                // Moving DOWN
                for (int rowNum = startRow; rowNum <= endRow; rowNum++)
                {
                    counter++;
                    matrix[rowNum, startCol] = counter;
                }
                startCol++;

                // Moving RIGHT
                for (int colNum = startCol; colNum <= endCol; colNum++)
                {
                    counter++;
                    matrix[endRow, colNum] = counter;
                }
                endRow--;

                // Moving UP
                for (int rowNum = endRow; rowNum >= startRow; rowNum--)
                {
                    counter++;
                    matrix[rowNum, endCol] = counter;
                }
                endCol--;

                // Moving LEFT
                for (int colNum = endCol; colNum >= startCol; colNum--)
                {
                    counter++;
                    matrix[startRow, colNum] = counter;
                }
                startRow++;
            }
            Print(matrix, n);
        }

        static void Main(string[] args)
        {
            int n = 4;

            OptionAFillByColumns(n);
            Console.WriteLine();

            OptionBUpAndDown(n);
            Console.WriteLine();

            OptionCFillHorizontally(n);
            Console.WriteLine();

            OptionDFillBySpiral(n);
        }
    }
}