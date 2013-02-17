/*
 * A dictionary is stored as a sequence of text lines containing words and their
 * explanations. Write a program that enters a word and translates it by using 
 * the dictionary. Sample dictionary:
 * 
 *          .NET – platform for applications from Microsoft
            CLR – managed execution environment for .NET
            namespace – hierarchical organization of classes
 */

using System;
using System.Collections.Generic;

class TranslateWord
{
    static void Main(string[] args)
    {
        string dictionary = ".NET - platform for applications from Microsoft\n" + 
                            "CLR - managed execution environment for .NET\n" + 
                            "namespace – hierarchical organization of classes";

        string[] byNewLine = dictionary.Split('\n');
        List<string[]> byDash = new List<string[]>();

        string[] separator = {" - "};
        
        for (int i = 0; i < byNewLine.Length; i++)
        {
            byDash.Add(byNewLine[i].Split(separator, StringSplitOptions.RemoveEmptyEntries));
        }

        Console.Write("Enter word: ");
        string word = Console.ReadLine().ToUpper();

        for (int i = 0; i < byDash.Count; i++)
        {
            if (word == byDash[i][0])
            {
                Console.Write(byDash[i][1] + "\n");
            }
        }
    }
}