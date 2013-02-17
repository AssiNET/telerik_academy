/*
 *Write a method that return the maximal element in a portion
 *of array of integers starting at given index. Using it write
 *another method that sorts an array in ascending / descending order.
 */

using System;

namespace Problem9_MaxElement
{
    class MaxElement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());                // Array dimension
            int index = int.Parse(Console.ReadLine());            // The index where the search for the max elemnt will start from.
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());           // next number in array
            }

            MaxItem(arr, index);
            SortAsec(arr);
            SortDesc(arr);
        }

        static void SortDesc(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int maxElement = arr[i];
                int maxIndex = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] > maxElement)
                    {
                        maxElement = arr[j];
                        maxIndex = j;
                    }
                }
                int temp = arr[i];
                arr[i] = maxElement;
                arr[maxIndex] = temp;
            }
            Console.Write("Descending sorting: ");
            Print(arr);
        }

        static void Print(int[] arr)
        {
            foreach (var number in arr)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        static void SortAsec(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minElement = arr[i];
                int minIndex = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < minElement)
                    {
                        minElement = arr[j];
                        minIndex = j;
                    }
                }
                int temp = arr[i];
                arr[i] = minElement;
                arr[minIndex] = temp;
            }
            Console.Write("Ascending sorting: ");
            Print(arr);
        }

        static void MaxItem(int[] arr, int index)
        {
            int maxElement = arr[index];
            for (int i = index; i < arr.Length; i++)
            {
                if (arr[i] > maxElement)
                {
                    maxElement = arr[i];
                }
            }
            Console.WriteLine("Max Number from index {0} till the end of array: {1}", index, maxElement);
        }
    }
}
