/*
 * We are given a string containing a list of forbidden words and a text 
 * containing some of these words. Write a program that replaces the 
 * forbidden words with asterisks. 
 *      Example:
 *      Microsoft announced its next generation PHP compiler today. 
 *      It is based on .NET Framework 4.0 and is implemented as a 
 *      dynamic language in CLR.
 *
 *      Words: "PHP, CLR, Microsoft"
 *      The expected result:
 *          ********* announced its next generation *** compiler today. 
 *          It is based on .NET Framework 4.0 and is implemented as a 
 *          dynamic language in ***.
 */

using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class ReplaceForbiddenWords
{
    static void Main(string[] args)
    {
        StringBuilder text = new StringBuilder("Microsoft announced its next generation PHP compiler today. " + 
                                               "It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.");

        string[] forbiddenWords = { "PHP", "CLR", "Microsoft" };

        try
        {
            Console.WriteLine(text);
            for (int j = 0; j < forbiddenWords.Length; j++)
            {
                text = new StringBuilder(Regex.Replace(text.ToString(), forbiddenWords[j], new String('*', forbiddenWords[j].Length)));
            }

            Console.WriteLine("\n" + text);
        }
        catch (OverflowException ofe)
        {
            Console.WriteLine(ofe.Message);
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