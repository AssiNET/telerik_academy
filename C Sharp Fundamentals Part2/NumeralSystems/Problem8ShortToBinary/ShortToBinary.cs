/*
 * 8.Write a program that shows the binary representation 
 * of given 16-bit signed integer number (the C# type short).
 */

using System;
using System.Collections.Generic;

namespace Problem8ShortToBinary
{
    class ShortToBinary
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 16-bit signed number: ");
            int number = int.Parse(Console.ReadLine());

            List<int> digits = new List<int>();

            if (number >= 0)
            {
                while (number != 0)
                {
                    digits.Add(number % 2);
                    number /= 2;
                }

                while (digits.Count % 16 != 0)
                {
                    digits.Add(0);
                }
                digits.Reverse();
            }
            else
            {
                number = Math.Abs(number) - 1;

                while (number != 0)
                {
                    digits.Add(number % 2);
                    number /= 2;
                }

                List<int> negativeNumber = new List<int>();
                for (int i = 0; i < digits.Count; i++)
                {
                    if (digits[i] == 0)
                    {
                        negativeNumber.Add(1);
                    }
                    else
                    {
                        negativeNumber.Add(0);
                    }
                }
                digits = negativeNumber;

                while (digits.Count % 16 != 0)
                {
                    digits.Add(1);
                }
                digits.Reverse();
            }
            Console.Write("Binary representation: ");
            foreach (var item in digits)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}