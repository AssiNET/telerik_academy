/*
 * Write a program that reads a string from the console and replaces 
 * all series of consecutive identical letters with a single one. 
 * Example: "aaaaabbbbbcdddeeeedssaa" -> "abcdedsa".
 */

using System;
using System.Text;

class ReplaceLetters
{
    static void Main(string[] args)
    {
        string str = "aaaaabbbbbcdddeeeedssaa";
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < str.Length - 1; i++)
        {
            if (str[i] != str[i + 1])
            {
                result.Append(str[i]);   
            }
        }
        result.Append(str[str.Length - 1]);
        
        Console.Write("{0} -> {1}\n", str, result);
    }
}