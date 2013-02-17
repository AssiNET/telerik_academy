/*
 * Write a program that extracts from a given text all palindromes,
 * e.g. "ABBA", "lamal", "exe".
 */

using System;

class FindPalindromes
{
    static void Main(string[] args)
    {
        string text = "ABCA, ABBA, Abba, lamal, exe, Telerik, Academy, Ninja";
        string[] separator = {", "};
        string[] words = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);

        bool isPalindrome = true;

        for (int wordIndex = 0; wordIndex < words.Length; wordIndex++)
        {
            for (int leftIndex = 0, rightIndex = words[wordIndex].Length - 1; leftIndex != words[wordIndex].Length; leftIndex++, rightIndex--)
            {
                if (words[wordIndex][leftIndex].ToString().ToUpper() != words[wordIndex][rightIndex].ToString().ToUpper())
                {
                    isPalindrome = false;
                    break;
                }
                else
                {
                    isPalindrome = true;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine(words[wordIndex]);
            }
        }
    }
}
