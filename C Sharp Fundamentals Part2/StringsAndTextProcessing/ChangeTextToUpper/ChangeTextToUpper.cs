/*
 * You are given a text. Write a program that changes the text in all regions 
 * surrounded by the tags <upcase> and </upcase> to uppercase. 
 * The tags cannot be nested. Example:
 *      We are living in a <upcase>yellow 
 *      submarine</upcase>. We don't have 
 *      <upcase>anything</upcase> else.
 * The expected result:
        We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.   
 */

using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class ChangeTextToUpper
{
    static void Main(string[] args)
    {
        string pattern = @"<upcase>(?<text>\w*\s\w*|\w*)</upcase>";
        StringBuilder text = new StringBuilder("We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.");

        try
        {
            Console.WriteLine(text);

            MatchCollection matches = Regex.Matches(text.ToString(), pattern);
            foreach (Match match in matches)
            {
                string matchedText = match.Groups["text"].Value;
                text = new StringBuilder(Regex.Replace(text.ToString(), matchedText, matchedText.ToUpper()));
            }

            Console.WriteLine("\n" + text);
        }
        catch (RegexMatchTimeoutException rme)
        {
            Console.WriteLine(rme.Message);
        }
        catch (ArgumentNullException ane)
        {
            Console.WriteLine(ane.Message);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
    }
}