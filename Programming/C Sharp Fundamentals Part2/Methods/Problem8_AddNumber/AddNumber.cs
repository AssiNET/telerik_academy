/*
 *Write a method that adds two positive integer numbers
 *represented as arrays of digits (each array element 
 *arr[i] contains a digit; the last digit is kept in arr[0]). 
 *Each of the numbers that will be added could have up to 
 *10 000 digits.
 */

using System;
using System.Collections.Generic;

namespace Problem8_AddNumber
{
    class AddNumber
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] firstNumber = IntegerToArray(input);

            input = Console.ReadLine();
            int[] secondNumber = IntegerToArray(input);

            Sum(firstNumber, secondNumber);
        }

        static void Sum(int[] firstNumber, int[] secondNumber)
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

            Print(sum);
        }

        static void Print(List<int> sum)
        {
            for (int index = sum.Count - 1; index >= 0; index--)
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
