/*
 * You are given a sequence of positive integer values 
 * written into a string, separated by spaces. Write a 
 * function that reads these values from given string 
 * and calculates their sum. 
 * 
 * Example:	string = "43 68 9 23 318" -> result = 461
 */

using System;

namespace Problem6CalculateSumFromString
{
    class CalculateSumFromString
    {
        static void Main(string[] args)
        {
            Console.Write("Enter sequence of positive integers numbers, separated by single \"space\": ");
            string[] sequence = Console.ReadLine().Split(' ');
            Sum(sequence);
        }
  
        static void Sum(string[] sequence)
        {
            int sum = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                sum += int.Parse(sequence[i]);
            }
            Console.WriteLine(sum);
        }
    }
}
