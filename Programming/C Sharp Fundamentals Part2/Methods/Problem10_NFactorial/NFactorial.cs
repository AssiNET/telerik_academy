/*
 *Write a program to calculate n! for each n in the range [1..100]. 
 *Hint: Implement first a method that multiplies a number represented 
 *as array of digits by given integer number. 
 */

using System;
using System.Collections.Generic;

namespace Problem10_NFactorial
{
    class NFactorial
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                GetFactorial(i);
            }
        }

        static void GetFactorial(int n)
        {
            int[] factorial = { 1 };
            
            for (int i = 1; i <= n; i++)
            {
                factorial = Multiply(factorial, i);
            }
            Print(factorial);
        }

        static int[] Multiply(int[] factorial, int i)
        {
            int[] result = { 0 };
            for (int j = 0; j < i; j++)
            {
                result = Sum(result, factorial);
            }
            return result;
        }

        static int[] Sum(int[] firstNumber, int[] secondNumber)
        {
            List<int> sum = new List<int>(Math.Max(firstNumber.Length, secondNumber.Length));
            int transferDigit = 0;

            for (int index = 0; index < sum.Capacity; index++)
            {
                int digit = (index < firstNumber.Length ? firstNumber[index] : 0) + (index < secondNumber.Length ? secondNumber[index] : 0) + transferDigit;
                sum.Add(digit % 10);
                transferDigit = digit / 10;
            }

            if (transferDigit == 1)
            {
                sum.Add(transferDigit);
            }

            return sum.ToArray();
        }

        static void Print(int[] sum)
        {
            for (int index = sum.Length - 1; index >= 0; index--)
            {
                Console.Write(sum[index]);
            }
            Console.WriteLine();
        }

        static int[] IntegerToArray(string input)
        {
            int[] number = new int[input.Length];

            for (int index = 0; index < input.Length; index++)
            {
                number[index] = int.Parse(input[number.Length - index - 1].ToString());
            }
            return number;
        }
    }
}