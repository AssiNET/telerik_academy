using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_MaxIncreasingSequence
{
    class Problem5_MaxIncreasingSequence
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 2, 3, 4, 2, 3, 4, 5, 6, 7, 8, 30, 2, 3 };
            int bestLength = 0;
            int length = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    length++;
                    if (length > bestLength)
                    {
                        bestLength = length;
                    }
                }
                else
                {
                    length = 1;
                }
            }
            Console.WriteLine(bestLength);
        }
    }
}
