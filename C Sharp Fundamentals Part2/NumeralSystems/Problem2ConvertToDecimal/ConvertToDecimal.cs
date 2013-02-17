/*
 * Write a program to convert binary numbers to their decimal representation.
 */

using System;

namespace Problem2ConvertToDecimal
{
    class ConvertToDecimal
    {
        static void Main(string[] args)
        {
            int number = 1010;
            ConvertToDec(number);
        }

        static void ConvertToDec(int number)
        {
            int decimalNum = 0;
            int power = 1;
            int digit = 0;

            for (int i = 0; i < number.ToString().Length; i++)
            {
                digit = int.Parse(number.ToString()[number.ToString().Length - i - 1].ToString());
                
                decimalNum += digit * power;  
                power *= 2;
            }
            Console.Write(number + " -> ");
            Console.WriteLine(decimalNum);
        }
    }
}
