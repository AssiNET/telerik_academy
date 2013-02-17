/*
 * Write a program that reads a date and time given in the format: 
 * day.month.year hour:minute:second and prints the date and time 
 * after 6 hours and 30 minutes (in the same format) along with 
 * the day of week in Bulgarian.
 */

using System;
using System.Globalization;

class PrintSixHoursLAter
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter date in format (day.month.year hour:minute:second): ");
        string dateAsStr = Console.ReadLine();

        DateTime date = DateTime.Parse(dateAsStr);

        date = date.AddHours(6);
        date = date.AddMinutes(30);

        Console.WriteLine(date + " " + date.ToString("dddd", new CultureInfo("bg-BG")));
    }
}
