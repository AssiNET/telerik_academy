/*
 * Write a method GetMax() with two parameters that returns
 * the bigger of two integers. Write a program that reads 3 
 * integers from the console and prints the biggest of them 
 * using the method GetMax().
 */

using System;

namespace Problem2_CompareIntegers
{
    class CompareIntegers
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            for (int i = 0; i < 3; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(GetMax(GetMax(numbers[0], numbers[1]), numbers[2]));
        }

        static int GetMax(int number1, int number2)
        {
            int maxNumber = number1;
            if (number2 > number1)
            {
                maxNumber = number2;
            }
            return maxNumber;
        }
    }
}
