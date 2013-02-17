using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_SortsByElementsLength
{
    class Problem5_SortsByElementsLength
    {
        class StringCompare : IComparer<string>
        {
            public int Compare(string word1, string word2) 
            {
                var word1Length = word1.Length;
                var word2Length = word2.Length;
                return word1Length.CompareTo(word2Length);
            }
        }

        static void Main(string[] args)
        {
            string[] words = { "abcdefg", "abcd", "abcde", "abc", "abcdef" };
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("\n");

            Array.Sort(words, new StringCompare());

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine();
        }
    }
}
