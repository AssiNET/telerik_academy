using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7_LargestAreaOfEquals
{
    class Problem7_LargestAreaOfEquals
    {
        public static int[,] matrix;
        public static bool[,] used;
        public static int largestArea = 0;
        public static int currentArea;
        
        public static int templateElement;

        static void FindLargestArea(int row, int col)
        {
            used[row, col] = true; 

            int[] neighbourRow = new int[] { -1, 1, 0, 0 };
            int[] neighbourCol = new int[] {  0, 0, 1, -1 };  
            
            used[row, col] = true;

            for (int i = 0; i < 4; i++)
            {
                if ( row + neighbourRow[i] >= 0 && row + neighbourRow[i] < matrix.GetLength(0) &&
                     col + neighbourCol[i] >= 0 && col + neighbourCol[i] < matrix.GetLength(1) )
                {
                    if ( matrix[row + neighbourRow[i], col + neighbourCol[i]] == templateElement &&
                         used[row + neighbourRow[i], col + neighbourCol[i]] == false )
                    {
                        currentArea++;
                        FindLargestArea(row + neighbourRow[i], col + neighbourCol[i]);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int currentElement = 0;
            matrix = new int[,] 
            {
                {1, 3, 2, 2, 2, 4},
                {3, 3, 3, 2, 4, 4},
                {4, 3, 1, 2, 3, 3}, 
                {4, 3, 1, 3, 3, 1},
                {4, 3, 3, 3, 1, 1}
            };

            used = new bool[matrix.GetLength(0), matrix.GetLength(1)];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (used[row, col] == false)                     
                    {
                        currentArea = 1;
                        templateElement = matrix[row, col];
                        FindLargestArea(row, col);
                        if (currentArea > largestArea)
                        {
                            largestArea = currentArea;
                            currentElement = templateElement;
                        }
                    }
                }
            }
            Console.WriteLine("Largest area of {0} is {1}", currentElement, largestArea);
        }
    }
}