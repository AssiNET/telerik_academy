/*
 *Write methods to calculate minimum, maximum, 
 *average, sum and product of given set of 
 *integer numbers. Use variable number of arguments.
 */

using System;

namespace Problem14_VariousMEthods
{
    class VariousMEthods
    {
        static void Main(string[] args)
        {
            Minimum(2, 1, 0, 5, 4, 8, 6);
            Maximum(2, 1, 20, 5, 4, 8, 6);
            Average(2, 3);
            Sum(1, 2, 3, 4, 5);
            Product(1, 2, 3, 4, 5);
        }

        static void Minimum(params int[] arr)
        {
            int minElement = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minElement)
                {
                    minElement = arr[i];
                }
            }
            Console.WriteLine("Min number of the sequence: {0}", minElement);
        }

        static void Maximum(params int[] arr)
        {
            int maxElement = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxElement)
                {
                    maxElement = arr[i];
                }
            }
            Console.WriteLine("Max number of the sequence: {0}", maxElement);
        }

        static void Average(params double[] arr)
        {
            double average = 0;
            foreach (var num in arr)
            {
                average += num;
            }
            average /= arr.Length;
            Console.WriteLine("The average of the sequence: {0}", average);
        }

        static void Sum(params int[] arr)
        {
            int sum = 0;
            foreach (var num in arr)
            {
                sum += num;
            }
            Console.WriteLine("The sum of the sequence: {0}", sum);
        }

        static void Product(params int[] arr)
        {
            int product = 1;
            foreach (var num in arr)
            {
                if (num == 0)
                {
                    product = 0;
                    break;
                }
                product *= num;
            }
            Console.WriteLine("The product of the sequence: {0}", product);
        }
    }
}