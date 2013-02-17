/*
Write a program to convert decimal numbers to their binary representation.
*/

using System;

namespace Problem1ConvertToBinary
{
    class ConvertToBinary
    {   
        static void Main(string[] args)
        {
            int number = 5;
            ConvertToBin(number);
            
            number = 151;
            ConvertToBin(number);

            number = 35;
            ConvertToBin(number);

            number = 43;
            ConvertToBin(number);

            number = 251;
            ConvertToBin(number);
            
        }
  
        static void ConvertToBin(int number, int bits = 8)
        {
            int[] binary = new int[bits];
            int num = number;

            for (int i = 0; i < binary.Length; i++)
            {
                if (num % 2 == 0)
                {
                    binary[binary.Length - i - 1] = 0;
                }
                else
                {
                    binary[binary.Length - i - 1] = 1;
                }
                num /= 2;
            }

            Console.Write(number + " -> ");
            Print(binary);
        }

        static void Print(int[] binary)
        {
            for (int i = 0; i < binary.Length; i++)
            {
                Console.Write(binary[i]);
            }
            Console.WriteLine();
        }
    }
}