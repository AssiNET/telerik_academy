/*
 * Write a program to convert from any numeral system of given base s 
 * to any other numeral system of base d (2 ≤ s, d ≤  16).
 */

using System;

namespace Problem7NumeralSystems
{
    class NumeralSystems
    {
        static void Main(string[] args)
        {
            FromXBaseToYBase("1F4", 16, 10);
            
        }

        static char ConvertToChar(int value)
        {
            switch (value)
            {
                case 10:
                    return 'A';
                    break;
                case 11:
                    return 'B';
                    break;
                case 12:
                    return 'C';
                    break;
                case 13:
                    return 'D';
                    break;
                case 14:
                    return 'E';
                    break;
                case 15:
                    return 'F';
                    break;
                default:
                    return char.Parse(value.ToString());
                    break;
            }
        }

        static int ConvertToNumber(string str, int position)
        {
            switch (char.ToUpperInvariant(str[position]))
            {
                case 'A':
                    return 10;
                    break;
                case 'B':
                    return 11;
                    break;
                case 'C':
                    return 12;
                    break;
                case 'D':
                    return 13;
                    break;
                case 'E':
                    return 14;
                    break;
                case 'F':
                    return 15;
                    break;
                default:
                    return int.Parse(str[position].ToString());
                    break;
            }
        }

        static int FromBaseXToBase10(string str, int fromBase)
        {
            int decNumber = 0;
            for (int i = str.Length - 1, p = 1; i >= 0; i--, p *= fromBase)
            {
                decNumber += ConvertToNumber(str, i) * p;
            }
            return decNumber;
        }

        static string FromBase10ToBaseX(int decNumber, int toBase)
        {
            string str = null;
            while (decNumber > 0)
            {
                str = new string(ConvertToChar(decNumber % toBase), 1) + str;
                decNumber /= toBase;
            }
            return str;
        }

        static void FromXBaseToYBase(string number, int xBase, int yBase)
        {
            Console.WriteLine(FromBase10ToBaseX(FromBaseXToBase10(number, xBase), yBase));
        }
    }
}
