/*
 * Write a program that shows the internal binary representation of given
 * 32-bit signed floating-point number in IEEE 754 format (the C# type float). 
 * Example: -27,25  sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.
 */

using System;
using System.Collections.Generic;

namespace Problem9FloatToIEEE754
{
    class FloatToIeee754
    {
        static void Main(string[] args)
        {
            float floatingPoint = -27.25F;
            string ieee = ToBin(ToHex(floatingPoint));

            for (int i = 0; i < ieee.Length; i++)
            {
                Console.Write(ieee[i]);
                if (i == 0 || i == 8)
                {

                    Console.Write("-");
                }
            }
            Console.WriteLine();
        }

        static string ToHex(float floatPoint)
        {
            byte[] bytes = BitConverter.GetBytes(floatPoint);
            Array.Reverse(bytes);
            string result = BitConverter.ToString(bytes);
            return result;
        }

        static string ToBin(string result)
        {
            List<string> binary = new List<string>();
            for (int i = 0; i < result.Length; i++)
            {
                switch (char.ToUpperInvariant(result[i]))
                {
                    case '0':
                        binary.Add("0000");
                        break;
                    case '1':
                        binary.Add("0001");
                        break;
                    case '2':
                        binary.Add("0010");
                        break;
                    case '3':
                        binary.Add("0011");
                        break;
                    case '4':
                        binary.Add("0100");
                        break;
                    case '5':
                        binary.Add("0101");
                        break;
                    case '6':
                        binary.Add("0110");
                        break;
                    case '7':
                        binary.Add("0111");
                        break;
                    case '8':
                        binary.Add("1000");
                        break;
                    case '9':
                        binary.Add("1001");
                        break;
                    case 'A':
                        binary.Add("1010");
                        break;
                    case 'B':
                        binary.Add("1011");
                        break;
                    case 'C':
                        binary.Add("1100");
                        break;
                    case 'D':
                        binary.Add("1101");
                        break;
                    case 'E':
                        binary.Add("1110");
                        break;
                    case 'F':
                        binary.Add("1111");
                        break;
                }
            }
            return string.Join("", binary);
        }
    }
}
