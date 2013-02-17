/*
 * Write a program to convert hexadecimal numbers to binary numbers (directly).
 */

using System;
using System.Text;

namespace Problem5HexademicalToBinary
{
    class HexademicalToBinary
    {
        static void Main(string[] args)
        {
            string hexademical = "1F4";
            ConvertToBinary(hexademical);

            hexademical = "ff";
            ConvertToBinary(hexademical);
        }

        static void ConvertToBinary(string hexademical)
        {
            char ch;
            StringBuilder binaryNum = new StringBuilder();

            for (int i = 0; i < hexademical.Length; i++)
            {
                ch = char.ToUpperInvariant(hexademical[i]);
                switch (ch)
                {
                    case '1':
                        binaryNum.Append("0001");
                        break;
                    case '2':
                        binaryNum.Append("0010");
                        break;
                    case '3':
                        binaryNum.Append("0011");
                        break;
                    case '4':
                        binaryNum.Append("0100");
                        break;
                    case '5':
                        binaryNum.Append("0101");
                        break;
                    case '6':
                        binaryNum.Append("0110");
                        break;
                    case '7':
                        binaryNum.Append("0111");
                        break;
                    case '8':
                        binaryNum.Append("1000");
                        break;
                    case '9':
                        binaryNum.Append("1001");
                        break;
                    case 'A':
                        binaryNum.Append("1010");
                        break;
                    case 'B':
                        binaryNum.Append("1011");
                        break;
                    case 'C':
                        binaryNum.Append("1100");
                        break;
                    case 'D':
                        binaryNum.Append("1101");
                        break;
                    case 'E':
                        binaryNum.Append("1110");
                        break;
                    case 'F':
                        binaryNum.Append("1111");
                        break;
                    default:
                        binaryNum.Append("0000");
                        break;
                }
            }
            string finalBinaryNum = binaryNum.ToString().TrimStart('0');
            Console.Write("0x" + hexademical + " -> ");
            Console.WriteLine(finalBinaryNum);   
        }
    }
}