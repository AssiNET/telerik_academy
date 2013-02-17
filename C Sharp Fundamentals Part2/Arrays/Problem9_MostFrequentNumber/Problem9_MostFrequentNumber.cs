using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9_MostFrequentNumber
{
    class Problem9_MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 4 };

            Array.Sort(array);

            int bestLength = 0;
            int length = 0;
            int number = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
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
                    number = array[i + 1];
                }
            }
            Console.WriteLine(number);
            Console.WriteLine(bestLength);

            //int maxCount = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    int count = 0;
            //    for (int j = i + 1; j < array.Length; j++)
            //    {
            //        if (array[i] == array[j])
            //        {
            //            count++;
            //            array[j] = int.MinValue;
            //        }
            //    }
            //    if (maxCount < count)
            //    {
            //        maxCount = count;
            //    }
            //}
            //Console.WriteLine(maxCount);
        }
    }
}
