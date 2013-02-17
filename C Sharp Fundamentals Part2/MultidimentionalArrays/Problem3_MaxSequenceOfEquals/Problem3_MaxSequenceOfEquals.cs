using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_MaxSequenceOfEquals
{
    class Problem3_MaxSequenceOfEquals
    {
        static void Main(string[] args)
        {
            string[,] strings =
            {
              { "ha", "fifi", "ho", "hi" },
              { "fo", "ha", "hi", "xx" },
              { "xxx", "ho", "ha", "xx" }
            };

            //string[,] strings =
            //{
            //  { "s", "qq", "ss" },
            //  { "pp", "pp", "ss" },
            //  { "pp", "qq", "ss" }
            //};

            int bestLength = 0;
            string str = null;

            for (int row = 0; row < strings.GetLength(0); row++)
            {
                for (int col = 0; col < strings.GetLength(1); col++)
                {
                    int length = 1;
                    int startRow = row;
                    int startCol = col;
                    
                    //UP 
                    while (row - 1 >= 0 && strings[row, col] == strings[row - 1, col])
                    {
                        length++;
                        row--;
                    }

                    if (length > bestLength)
                    {
                        str = strings[startRow, startCol];
                        bestLength = length;
                        length = 0;
                    }
                    row = startRow;

                    //DOWN 
                    while (row + 1 < strings.GetLength(0) && strings[row, col] == strings[row + 1, col])
                    {
                        length++;
                        row++;
                    }

                    if (length > bestLength)
                    {
                        str = strings[startRow, startCol];
                        bestLength = length;
                        length = 0;
                    }
                    row = startRow;

                    //RIGHT 
                    while (col + 1 < strings.GetLength(1) && strings[row, col] == strings[row, col + 1])
                    {
                        length++;
                        col++;
                    }

                    if (length > bestLength)
                    {
                        str = strings[startRow, startCol];
                        bestLength = length;
                        length = 0;
                    }
                    col = startCol;

                    //LEFT 
                    while (col - 1 >= 0 && strings[row, col] == strings[row, col - 1])
                    {
                        length++;
                        col--;
                    }
                    col = startCol;

                    if (length > bestLength)
                    {
                        str = strings[startRow, startCol];
                        bestLength = length;
                        length = 0;
                    }

                    //UP-LEFT 
                    while (col - 1 >= 0 && row - 1 >= 0 && strings[row, col] == strings[row - 1, col - 1])
                    {
                        length++;
                        row--;
                        col--;
                    }
                    row = startRow;
                    col = startCol;

                    if (length > bestLength)
                    {
                        str = strings[startRow, startCol];
                        bestLength = length;
                        length = 0;
                    }

                    //UP-RIGHT 
                    while (col + 1 < strings.GetLength(1) && row - 1 >= 0 && strings[row, col] == strings[row - 1, col + 1])
                    {
                        length++;
                        row--;
                        col++;
                    }
                    row = startRow;
                    col = startCol;

                    if (length > bestLength)
                    {
                        str = strings[startRow, startCol];
                        bestLength = length;
                        length = 0;
                    }

                    //DOWN-LEFT 
                    while (col - 1 >= 0 && row + 1 < strings.GetLength(0) && strings[row, col] == strings[row + 1, col - 1])
                    {
                        length++;
                        row++;
                        col--;
                    }
                    row = startRow;
                    col = startCol;

                    if (length > bestLength)
                    {
                        str = strings[startRow, startCol];
                        bestLength = length;
                        length = 0;
                    }

                    //DOWN-RIGHT 
                    while (col + 1 < strings.GetLength(1) && row + 1 < strings.GetLength(0) && strings[row, col] == strings[row + 1, col + 1])
                    {
                        length++;
                        row++;
                        col++;
                    }
                    row = startRow;
                    col = startCol;

                    if (length > bestLength)
                    {
                        str = strings[startRow, startCol];
                        bestLength = length;
                    }
                }
            }
            for (int i = 0; i < bestLength; i++)
            {
                Console.Write("{0} ", str);
            }
            Console.WriteLine();
        }
    }
}
