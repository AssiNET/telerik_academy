using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem18_LongestIncreasingSequence
{
    class Problem18_LongestIncreasingSequence
    {
        static void Main(string[] args)
        {
            int n = 9;
            int[] arr = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
            int maxLength = 1;
            int bestEnd = 0;
            int[] length = new int[n];
            int[] previous = new int[n];
            length[0] = 1;
            previous[0] = -1;

            for (int i = 1; i < n; i++)
            {
                length[i] = 1;
                previous[i] = -1;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (length[j] + 1 > length[i] && arr[j] <= arr[i])
                    {
                        length[i] = length[j] + 1;
                        previous[i] = j;
                    }
                }

                if (length[i] > maxLength)
                {
                    bestEnd = i;
                    maxLength = length[i];
                }
            }

            int[] newArr = new int[maxLength];
            int counter = maxLength - 1;
            int index = bestEnd;

            while (index != -1)
            {
                newArr[counter] = arr[index];
                counter--;
                index = previous[index];
            }

            foreach (var number in arr)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\n");

            foreach (var number in newArr)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}