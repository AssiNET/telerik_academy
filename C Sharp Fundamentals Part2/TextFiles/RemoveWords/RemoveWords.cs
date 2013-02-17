/*
 * Write a program that removes from a text file all words listed 
 * in given another text file. Handle all possible exceptions in your methods.
 */

using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class RemoveWords
{
    static void Main(string[] args)
    {
        string inputFile = "..//..//inputFile.txt";
        string outputFile = "..//..//outputFile.txt";
        string wordsForRemove = "..//..//wordsForRemove.txt";

        try
        {
            StreamReader inputStream = new StreamReader(inputFile);         //Open the input file
            using (inputStream)
            {
                StreamWriter writer = new StreamWriter(outputFile);        //Write the output file
                using (writer)
                {
                    StreamReader matchStream = new StreamReader(wordsForRemove);  //Open the file with word which should be removed from the input file
                    using (matchStream)
                    {
                        string line = inputStream.ReadLine();
                        StringBuilder newLine = new StringBuilder(line);

                        while (line != null)
                        {
                            string word = matchStream.ReadLine();
                         
                            while (word != null)
	                        {
	                            string pattern = "\\b"+word+"\\b";
                                newLine = new StringBuilder(Regex.Replace(newLine.ToString(), pattern, " "));
                            
                                word = matchStream.ReadLine();
                            }
                            writer.WriteLine(newLine);
                            writer.Flush();
                            
                            line = inputStream.ReadLine();
                        }
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