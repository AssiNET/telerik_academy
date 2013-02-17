using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_MaxSequenceOfEquals
{
    class Problem4_MaxSequenceOfEquals
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 1, 1, 2, 3, 3, 3, 3, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int bestLength = 0;
            int length = 0;

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
                }
            }
            Console.WriteLine(bestLength);
        }
    }
}