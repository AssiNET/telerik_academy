using System;

class NumbersAsSpiral
{
    static void Main()
    {
        byte n = 0;
        ushort[,] spiralMatrix;

        while (true)
        {
            Console.Write("Enter value between [1 - 19] for n: ");
            if (byte.TryParse(Console.ReadLine(), out n) && n < 20)
            {
                ushort counter = 0;
                spiralMatrix = new ushort[n, n];
                byte startRow = 0;
                sbyte endRow = (sbyte)(n - 1);
                byte startCol = 0;
                sbyte endCol = (sbyte)(n - 1);
                
                while (counter < n*n)
                {
                    // Moving to the RIGHT (column offset)
                    for (byte colNum = startCol; colNum <= endCol; colNum++)
                    {
                        counter++;
                        spiralMatrix[startRow, colNum] = counter;
                    }
                    startRow++;

                    // Moving to the BOTTOM (row offset)
                    for (byte rowNum = startRow; rowNum <= endRow; rowNum++)
                    {
                        counter++;
                        spiralMatrix[rowNum, endCol] = counter;
                    }
                    endCol--;

                    // Moving to the LEFT (column offset)
                    for (sbyte colNum = endCol; colNum >= startCol; colNum--)
                    {
                        counter++;
                        spiralMatrix[endRow, colNum] = counter;
                    }
                    endRow--;

                    // Moving to the TOP (row offset)
                    for (sbyte rowNum = endRow; rowNum >= startRow; rowNum--)
                    {
                        counter++;
                        spiralMatrix[rowNum, startCol] = counter;
                    }
                    startCol++;
                }
                break;
            }
            else
            {
                Console.WriteLine("Wrong input!!!");
            }
        }

        // Printing the spiral
        for (ushort row = 0; row <= n - 1; row++)
        {
            for (ushort col = 0; col <= n - 1; col++)
            {
                Console.Write("{0, 4}", spiralMatrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}