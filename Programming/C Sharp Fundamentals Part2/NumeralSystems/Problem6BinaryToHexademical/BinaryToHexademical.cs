/*
* Write a program to convert binary numbers to hexadecimal numbers (directly).
*/

using System;
using System.Text;

namespace Problem6BinaryToHexademical
{
    class BinaryToHexademical
    {
        static void Main(string[] args)
        {
            string binary = "11010";
            ConvertToHexadecimal(binary);
        }

        static void ConvertToHexadecimal(string binary)
        {
            StringBuilder hexadecimalNum = new StringBuilder();

            if (binary.Length % 4 != 0)
            {
                binary = new string('0', 4 - binary.Length % 4) + binary;
            }
            for (int i = 0; i < binary.Length; i += 4)
            {
                switch (binary.Substring(i, 4))
                {
                    case "0001":
                        hexadecimalNum.Append("1");
                        break;
                    case "0010":
                        hexadecimalNum.Append("2");
                        break;
                    case "0011":
                        hexadecimalNum.Append("3");
                        break;
                    case "0100":
                        hexadecimalNum.Append("4");
                        break;
                    case "0101":
                        hexadecimalNum.Append("5");
                        break;
                    case "0110":
                        hexadecimalNum.Append("6");
                        break;
                    case "0111":
                        hexadecimalNum.Append("7");
                        break;
                    case "1000":
                        hexadecimalNum.Append("8");
                        break;
                    case "1001":
                        hexadecimalNum.Append("9");
                        break;
                    case "1010":
                        hexadecimalNum.Append("A");
                        break;
                    case "1011":
                        hexadecimalNum.Append("B");
                        break;
                    case "1100":
                        hexadecimalNum.Append("C");
                        break;
                    case "1101":
                        hexadecimalNum.Append("D");
                        break;
                    case "1110":
                        hexadecimalNum.Append("E");
                        break;
                    case "1111":
                        hexadecimalNum.Append("F");
                        break;
                    default:
                        hexadecimalNum.Append("0");
                        break;
                }
            }
            Console.Write(binary + " -> ");
            Console.WriteLine("0x" + hexadecimalNum);
        }
    }
}