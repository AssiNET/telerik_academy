using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12_PrintEachLetterIndex
{
    class Problem12_PrintEachLetterIndex
    {
        static void Main(string[] args)
        {
            char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            string letters = string.Join("", alphabet);

            string word = Console.ReadLine();

            string wordToLower = word.ToLowerInvariant();
            string lettersToLower = letters.ToLowerInvariant();

            for (int i = 0; i < wordToLower.Length; i++)
            {
                for (int j = 0; j < lettersToLower.Length; j++)
                {
                    if (wordToLower[i] == lettersToLower[j])
                    {
                        Console.WriteLine("{0} = {1}", word[i], j);
                    }
                }
            }
        }
    }
}
