/*
 *Write a method that counts how many times given number appears
 *in given array. Write a test program to check if the method 
 *is working correctly.
 */

using System;

namespace Problem4_CountNumber
{
    public class CountNumber
    {
        static void Main(string[] args)
        {
            int numberToCount = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(NumberSearch(numberToCount, numbers));
        }

        public static string NumberSearch(int numberToCount, int[] numbers)
        {
            int count = 0;

            foreach (int number in numbers)
            {
                if (number == numberToCount)
                {
                    count++;
                }
            }

            if (count != 0)
            {
                return count.ToString();
            }
            else
            {
                return "Number " + numberToCount + " does not appear in the array!";
            }
        }
    }
}
