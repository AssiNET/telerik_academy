/*
 * Write a program that reads a year from the console 
 * and checks whether it is a leap. Use DateTime.
 */

using System;

namespace Problem1CheckIsLeapYear
{
    class CheckIsLeapYear
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());

            if (ValidateYear(year))
            {
                bool isLeap = DateTime.IsLeapYear(year);

                if (isLeap)
                {
                    Console.WriteLine("Year {0} is leap.", year);
                }
                else
                {
                    Console.WriteLine("Year {0} is not leap.", year);
                }
            }
            else
            {
                Console.WriteLine("Enter year between 1 and 9999.");
            }
            
        }

        static bool ValidateYear(int year)
        {
            if (year >= 1 && year <= 9999)
            {
                return true;
            }
            return false;
        }
    }
}
