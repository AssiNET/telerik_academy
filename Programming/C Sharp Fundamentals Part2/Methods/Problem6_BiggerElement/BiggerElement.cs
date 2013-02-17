/*
 *Write a method that returns the index of the first element in array 
 *that is bigger than its neighbors, or -1, if there’s no such element.
 *(Use the method from the previous exercise.)
 */

using System;

namespace Problem6_BiggerElement
{
    class BiggerElement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(FirstBiggerElement(arr));
        }

        static int FirstBiggerElement(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i > 0 && i < arr.Length - 1)
                {
                    if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}