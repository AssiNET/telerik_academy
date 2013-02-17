/*
 * Write a program that reads a list of words, separated by spaces 
 * and prints the list in an alphabetical order.
 */

using System;
using System.Collections.Generic;

class SortWordsAlphabetically
{
    static void Main(string[] args)
    {
        string list = "Lorem ipsum dolor sit amet consectetur adipiscing elit Nulla commodo mollis erat sed eleifend arcu";

        string[] words = list.Split(' ');

        List<string> listOfWords = new List<string>(words);
        listOfWords.Sort();

        foreach (string word in listOfWords)
        {
            Console.WriteLine(word);
        }
    }
}