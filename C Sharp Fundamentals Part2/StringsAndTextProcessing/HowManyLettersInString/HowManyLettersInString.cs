/*
 * Write a program that reads a string from the console and prints 
 * all different letters in the string along with information how 
 * many times each letter is found. 
 */

using System;

class HowManyLettersInString
{
    static void Main(string[] args)
    {
        //string str = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla imperdiet.";

        Console.WriteLine("Enter a string: ");
        string str = Console.ReadLine();

        string[] words = str.Split(new string[] { ", ", " ", ". ", "." }, StringSplitOptions.RemoveEmptyEntries);

        char[] lettersCount = new char[65536];

        for (int i = 0; i < words.Length; i++)
        {
            for (int j = 0; j < words[i].Length; j++)
            {
                lettersCount[words[i][j]] += (char)1;
            }
        }
        
        for (int i = 0; i < lettersCount.Length; i++)
        {
            if (lettersCount[i] != 0)
            {
                Console.WriteLine("Letter {0} is found {1} time/times.", (char)i, (int)lettersCount[i]);
            }
        }
    }
}