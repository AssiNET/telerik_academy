/*
 *Write a method that reverses the 
 *digits of given decimal number. 
 *(Example: 256  652)
 */

using System;
using System.Text;
using System.Threading;
using System.Globalization;

namespace Problem7_ReverseDigits
{
    class ReverseDigits
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            float number = float.Parse(Console.ReadLine());
            Console.WriteLine(Reverse(number));
        }

        static StringBuilder Reverse(float number)
        {
            StringBuilder numberAsString = new StringBuilder();

            for (int i = number.ToString().Length - 1; i >= 0; i--)
            {
                numberAsString.Append(number.ToString()[i]);
            }

            return numberAsString;
        }
    }
}
