/*
 * Write a program that reverses the words in given sentence.
 * Example: "C# is not C++, not PHP and not Delphi!" -> "Delphi not and PHP, not C++ not is C#!".
 */
using System;
using System.Text.RegularExpressions;

namespace ReverseSentence
{
    class ReverseSentence
    {
        static void Main(string[] args)
        {
            string sentence = "C# is not C++, not PHP and not Delphi!";
            
            MatchCollection words = Regex.Matches(sentence, @"\b[\w.+]+[^,!\s]",RegexOptions.IgnorePatternWhitespace);
            MatchCollection punctuation = Regex.Matches(sentence, @"\b[\w.+]+[^\s]", RegexOptions.IgnorePatternWhitespace);

            int counter = words.Count - 1;
            string[] arrWords = new string[words.Count];

            foreach (var word in words)
	        {
                arrWords[counter--] = word.ToString();
	        }

            counter = 0;
            string[] arrPunctuation = new string[words.Count];

            foreach (var word in punctuation)
            {
                arrPunctuation[counter++] = word.ToString();
            }

            for (int i = 0; i < arrPunctuation.Length; i++)
            {
                for (int j = arrPunctuation[i].Length - 1; j >= 0 ; j--)
                {
                    if (arrPunctuation[i][j] == ',' || arrPunctuation[i][j] == '!' || arrPunctuation[i][j] == ':'
                        || arrPunctuation[i][j] == ';' || arrPunctuation[i][j] == '.')
                    {
                        arrWords[i] = arrWords[i] + arrPunctuation[i][j] + " ";
                        break;
                    }
                    else if (arrPunctuation[i][j] != ',' || arrPunctuation[i][j] != '!')
                    {
                        arrWords[i] = arrWords[i] + " ";
                        break;
                    }
                }
            }

            Console.WriteLine(sentence);
            foreach (var item in arrWords)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}