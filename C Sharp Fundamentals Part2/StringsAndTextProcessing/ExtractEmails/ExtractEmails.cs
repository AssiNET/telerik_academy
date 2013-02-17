/*
 * Write a program for extracting all email addresses from given text. 
 * All substrings that match the format <identifier>@<host>…<domain> 
 * should be recognized as emails.
 */

using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main(string[] args)
    {
        string text = "Please contact us by phone (+359 222 222 222) or by email at " +
                        "example@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: " +
                        "test@test. This also: @telerik.com. Neither this: a@a.b.";
        
        string pattern = @"([^\s""(),:;<>@[\]]{4,})\@(\w{3,})\.(\w{2,}(?:\.\w{2,})?)";
        
        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            Console.Write(match.Groups[1]);
            Console.Write("@");
            Console.Write(match.Groups[2]);
            Console.Write(".");
            Console.Write(match.Groups[3]);
            Console.WriteLine();
        }
    }
}
