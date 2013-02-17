using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem14_Quicksort
{
    class Problem14_Quicksort
    {
        static int Partition(int[] array, int leftMost, int rightMost, int pivotIndex)
        {
            int pivotValue = array[pivotIndex];
            int temp = array[rightMost];
            array[rightMost] = pivotValue;
            array[pivotIndex] = temp;
            int storeIndex = leftMost;

            for (int i = leftMost; i < rightMost; i++)
            {
                if (array[i] < pivotValue)
                {
                    temp = array[i];
                    array[i] = array[storeIndex];
                    array[storeIndex] = temp;
                    storeIndex += 1;
                }
            }
            temp = array[storeIndex];
            array[storeIndex] = array[rightMost];
            array[rightMost] = temp;
            return storeIndex;
        }

        static void Sort(int[] array, int leftMost, int rightMost)
        {
            if (leftMost < rightMost)
            {
                int pivotIndex = (leftMost + rightMost) / 2;
                int pivotNewIndex = Partition(array, leftMost, rightMost, pivotIndex);

                Sort(array, leftMost, pivotNewIndex - 1);
                Sort(array, pivotNewIndex + 1, rightMost);
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 5, 3, 6, 4, 9, 7, 8 };

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n");
            
            Sort(array, 0, array.Length - 1);

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}