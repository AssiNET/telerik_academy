/*
 * Write a program that extracts from a given text all dates that match
 * the format DD.MM.YYYY. Display them in the standard date format for Canada.
 */

using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

class ExtractDatesFromText
{
    static void Main(string[] args)
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");

        string text = "I was born at 14.06.1980. My sister was born at 3.7.1984. In " +
                      "5/1999 I graduated my high school. The law says (see section " +
                      "7.3.12) that we are allowed to do this (section 7.4.2.9).";
        
        string pattern = @"\d{1,2}\.\d{1,2}\.\d{4}";

        MatchCollection dates =  Regex.Matches(text, pattern);

        foreach (Match dateObj in dates)
        {
            DateTime date;
            if (DateTime.TryParseExact(dateObj.Value, "d.M.yyyy", CultureInfo.DefaultThreadCurrentCulture, DateTimeStyles.None, out date))
            {
                Console.WriteLine(date.ToString(CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern));
            }
        }
    }
}