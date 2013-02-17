using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8_SequenceOfMaximalSum
{
    class Problem8_SequenceOfMaximalSum
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            int maxSum = int.MinValue;
            int maxStartIndex = 0;
            int maxEndIndex = 0;
            int currentMaxSum = 0;
            int currentStartIndex = 1;

            for (int currentEndIndex = 1; currentEndIndex < array.Length; currentEndIndex++)
            {
                currentMaxSum += array[currentEndIndex];

                if (currentMaxSum > maxSum)
                {
                    maxSum = currentMaxSum;
                    maxStartIndex = currentStartIndex;
                    maxEndIndex = currentEndIndex;
                }

                if (currentMaxSum < 0)
                {
                    currentMaxSum = 0;
                    currentStartIndex = currentEndIndex + 1;
                }
            }

            for (int i = maxStartIndex; i <= maxEndIndex; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine(maxSum);
        }
    }
}