/*
 * Write a program to convert decimal numbers to their hexadecimal representation
 */

using System;

namespace Problem3DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main(string[] args)
        {
            int number = 500;
            ConvertToHexadecimal(number);
        }

        static void ConvertToHexadecimal(int number)
        {
            int[] hexadecimal = new int[number.ToString().Length];
            int digit = 0;
            for (int i = 0; i < hexadecimal.Length; i++)
            {
                digit = number - (number / 16) * 16;
                if (number < 16)
                {
                    hexadecimal[hexadecimal.Length - i - 1] = number;
                }
                else
                {
                    hexadecimal[hexadecimal.Length - i - 1] = digit;    
                }
                number /= 16;
            }

            Print(hexadecimal);
        }
  
        static void Print(int[] hexadecimal)
        {
            Console.Write("0x");
            foreach (var digit in hexadecimal)
            {
                switch (digit)
                {
                    case 10:
                        Console.Write('A');
                        break;
                    case 11:
                        Console.Write('B');
                        break;
                    case 12:
                        Console.Write('C');
                        break;
                    case 13:
                        Console.Write('D');
                        break;
                    case 14:
                        Console.Write('E');
                        break;
                    case 15:
                        Console.Write('F');
                        break;
                    default:
                        Console.Write(digit);
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}