/*
 * Write a program that deletes from a text file all words 
 * that start with the prefix "test". Words contain only 
 * the symbols 0...9, a...z, A…Z, _.
 */

using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class DeleteWordsWithPerfix
{
    static void Main(string[] args)
    {
        string inputFile = "..//..//input.txt";
        string outputFile = "..//..//output.txt";
        string pattern = @"\btest\w*\b";

        try
        {
            StreamReader reader = new StreamReader(inputFile);

            using (reader)
            {
                StreamWriter writer = new StreamWriter(outputFile);
                using (writer)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        string newLine = Regex.Replace(line, pattern, " ");
                        writer.WriteLine(newLine);
                        writer.Flush();
                        line = reader.ReadLine();
                    }
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
