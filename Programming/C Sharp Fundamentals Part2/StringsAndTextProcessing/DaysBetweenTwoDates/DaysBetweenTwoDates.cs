/*
 * Write a program that reads two dates in the format: day.month.year and 
 * calculates the number of days between them. Example:
 *      Enter the first date: 27.02.2006
        Enter the second date: 3.03.2004
        Distance: 4 days

 */

using System;

class DaysBetweenTwoDates
{
    static void Main(string[] args)
    {
        string date1AsStr = "27.02.2006";
        string date2AsStr = "3.03.2006";

        DateTime date1 = DateTime.Parse(date1AsStr);
        DateTime date2 = DateTime.Parse(date2AsStr);

        TimeSpan daysBetween = (date2 > date1 ? date2 - date1 : date1 - date2);
        Console.WriteLine(daysBetween.TotalDays);
    }
}