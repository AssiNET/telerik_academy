/*
 * Modify your last program and try to make it work 
 * for any number type, not just integer (e.g. decimal, 
 * float, byte, etc.). Use generic method 
 * (read in Internet about generic methods in C#).
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace Problem15_GenericMethods
{
    class GenericMethods
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Minimum(2, 1, 0, 5, 4, 8, 6);
            Maximum(2, 1, 20, 5, 4, 8, 6);
            Average<double>(2, 3);
            Sum(1, 2, 3, 4, 5);
            Product(1, 2, 3, 4, 5);
        }

        static void Minimum<T>(params T[] arr)
        {
            dynamic minElement = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minElement)
                {
                    minElement = arr[i];
                }
            }
            Console.WriteLine("Min number of the sequence: {0}", minElement);
        }

        static void Maximum<T>(params T[] arr)
        {
            dynamic maxElement = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxElement)
                {
                    maxElement = arr[i];
                }
            }
            Console.WriteLine("Max number of the sequence: {0}", maxElement);
        }

        static void Average<T>(params T[] arr)
        {
            dynamic average = 0;
            foreach (var num in arr)
            {
                average += num;
            }
            average /= arr.Length;
            Console.WriteLine("The average of the sequence: {0}", average);
        }

        static void Sum<T>(params T[] arr)
        {
            dynamic sum = 0;
            foreach (var num in arr)
            {
                sum += num;
            }
            Console.WriteLine("The sum of the sequence: {0}", sum);
        }

        static void Product<T>(params T[] arr)
        {
            dynamic product = 1;
            foreach (var num in arr)
            {
                product *= num;
            }
            Console.WriteLine("The product of the sequence: {0}", product);
        }
    }
}