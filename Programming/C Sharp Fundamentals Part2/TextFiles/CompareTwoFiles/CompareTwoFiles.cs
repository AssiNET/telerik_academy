/*
 * Write a program that compares two text files line by line 
 * and prints the number of lines that are the same and the 
 * number of lines that are different. Assume the files have 
 * equal number of lines.
 */

using System;
using System.IO;

class CompareTwoFiles
{
    static void Main(string[] args)
    {
        CompareLineByLine("..//..//FirstFile.txt", "..//..//SecondFile.txt");
    }

    static void CompareLineByLine(string firstFile, string secondFile)
    {
        try
        {
            StreamReader firstReader = new StreamReader(firstFile);
            StreamReader secondReader = new StreamReader(secondFile);

            using (firstReader)
            using (secondReader)
            {
                string lineFirstFile = firstReader.ReadLine();
                string lineSecondFile = secondReader.ReadLine();
                int counter = 1;
                while (lineFirstFile != null || lineSecondFile != null)
                {
                    if (lineFirstFile == null && lineSecondFile != null || lineFirstFile != null && lineSecondFile == null)
                    {
                        Console.WriteLine("Both file have different number of lines!");
                        break;
                    }

                    if (lineFirstFile == lineSecondFile)
                    {
                        Console.WriteLine("Line {0}: {1}", counter, lineFirstFile);
                    }

                    counter++;
                    lineFirstFile = firstReader.ReadLine();
                    lineSecondFile = secondReader.ReadLine();
                }

                
            }
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
        catch (FileNotFoundException fe)
        {
            Console.WriteLine(fe.Message);
        }
    }
}
