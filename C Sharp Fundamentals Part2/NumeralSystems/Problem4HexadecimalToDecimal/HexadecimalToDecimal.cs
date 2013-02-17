/*
 *Write a program to convert hexadecimal numbers to their decimal representation.
 */

using System;

namespace Problem4HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {
        static void Main(string[] args)
        {
            string hexadecimal = "1f4";
            ConvertToDecimal(hexadecimal);

            hexadecimal = "FF";
            ConvertToDecimal(hexadecimal);
            hexadecimal = "9876";
            ConvertToDecimal(hexadecimal);

            hexadecimal = "ABCDEF";
            ConvertToDecimal(hexadecimal);
        }

        static void ConvertToDecimal(string hexadecimal)
        {
            int decimalNum = 0;
            int power = 1;
            int digit = 0;
            for (int i = 0; i < hexadecimal.Length; i++)
            {
                char ch = hexadecimal[hexadecimal.Length - i - 1];
                ch = char.ToUpperInvariant(ch);
                switch (ch)
                {
                    case 'A':
                        digit = 10;
                        break;
                    case 'B':
                        digit = 11;
                        break;
                    case 'C':
                        digit = 12;
                        break;
                    case 'D':
                        digit = 13;
                        break;
                    case 'E':
                        digit = 14;
                        break;
                    case 'F':
                        digit = 15;
                        break;
                    default:
                        digit = int.Parse(hexadecimal[hexadecimal.Length - i - 1].ToString());
                        break;
                }
                decimalNum += digit * power;
                power *= 16;
            }
            Console.Write("0x" + hexadecimal + " -> ");
            Console.WriteLine(decimalNum);
        }
    }
}