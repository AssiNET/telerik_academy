﻿/*
 * Write a program that prints to the console 
 * which day of the week is today. Use System.DateTime.
 */

using System;

namespace Problem3CurrentDay
{
    class CurrentDay
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Today is {0}.", DateTime.Now.DayOfWeek);
        }
    }
}
