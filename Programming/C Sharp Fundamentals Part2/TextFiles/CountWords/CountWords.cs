/*
 * Write a program that reads a list of words from a file words.txt 
 * and finds how many times each of the words is contained in another 
 * file test.txt. The result should be written in the file result.txt 
 * and the words should be sorted by the number of their occurrences 
 * in descending order. Handle all possible exceptions in your methods.
 */

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;

class CountWords
{
    static void Main(string[] args)
    {
        try
        {
            StreamReader words = new StreamReader("..//..//words.txt");
            IDictionary<string, int> wordsList = new Dictionary<string, int>();
            using (words)
            {
                string line = words.ReadLine();
                while (line != null)
                {
                    wordsList[line] = 0;
                    line = words.ReadLine();
                }
            }

            StreamReader testWords = new StreamReader("..//..//test.txt");
            using (testWords)
            {
                string line = testWords.ReadLine();
                while (line != null)
                {
                    string[] arrLine= line.Split(' ');
                    foreach (var word in arrLine)
                    {
                        if (wordsList.ContainsKey(word))
                        {
                            wordsList[word] = wordsList[word] + 1;   
                        }
                    }
                    line = testWords.ReadLine();
                }
            }

            var items = from pair in wordsList
                        orderby pair.Value descending
                        select pair;

            StreamWriter writer = new StreamWriter("..//..//result.txt");
            using (writer)
            {
                foreach (KeyValuePair<string, int> pair in items)
	            {
	                 writer.WriteLine("{0} - {1}", pair.Key, pair.Value);
                     writer.Flush();
	            }
            }
        }
        catch (FileNotFoundException fe)
        {
            Console.WriteLine(fe.Message);
        }
        catch (DirectoryNotFoundException de)
        {
            Console.WriteLine(de.Message);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
        catch (OutOfMemoryException om)
        {
            Console.WriteLine(om.Message);
        }
    }
}