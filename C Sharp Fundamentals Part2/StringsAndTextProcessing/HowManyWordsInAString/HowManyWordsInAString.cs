/*
 * Write a program that reads a string from the console and lists all different
 * words in the string along with information how many times each word is found.
 */

using System;
using System.Collections;
using System.Collections.Generic;

class HowManyWordsInAString
{
    static void Main(string[] args)
    {
        string text = "Lorem ipsum dolor sit amet, Lorem ipsum adipiscing elit. Sed adipiscing elit aliquam mi." +
                      " Morbi non rhoncus velit. Nullam rhoncus velit, tortor at suscipit elementum, tortor " + 
                      "lectus dignissim nisl, in aliquet tortor tellus at diam. Quisque pretium aliquam ";

        string[] words = text.Split(new string[] { ", ", " ", ". ", "." }, StringSplitOptions.RemoveEmptyEntries);
        
        IDictionary<string, int> wordCount = new Dictionary<string, int>(); 
        
        foreach (string word in words)
        {
            if (wordCount.ContainsKey(word))
            {
                wordCount[word] += 1; 
            }
            else
            {
                wordCount[word] = 1;
            }
        }

        foreach (var item in wordCount)
        {
            Console.WriteLine("{0} - {1}", item.Key, item.Value);
        }
    }
}