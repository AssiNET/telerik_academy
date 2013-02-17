/*
 * Write a program that extracts from a given text all sentences containing given word.
 *		Example: 
 *          The word is "in". The text is:
 *          We are living in a yellow submarine. We don't have anything else. 
 *          Inside the submarine is very tight. So we are drinking all the day. 
 *          We will move out of it in 5 days.
 *      The expected result is:
 *          We are living in a yellow submarine.
 *          We will move out of it in 5 days.
 */

using System;
using System.IO;

class ExtractSentences
{
    static void Main(string[] args)
    {
        string text = "We are living in a yellow submarine. We don't have anything else. " +
                      "Inside the submarine is very tight. So we are drinking all the day. " +
                      "We will move out of it in 5 days.";

        string[] sentences = text.Split('.');

        for (int i = 0; i < sentences.Length; i++)
        {
            try
            {
                if (sentences[i].IndexOf(" in ") != -1)
                {
                    Console.WriteLine(sentences[i].Trim() + ".");
                }
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
        }
    }
}