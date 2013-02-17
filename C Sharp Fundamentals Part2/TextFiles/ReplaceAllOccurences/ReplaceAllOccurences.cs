/*
 * Write a program that replaces all occurrences of the substring "start"
 * with the substring "finish" in a text file. 
 * Ensure it will work with large files (e.g. 100 MB).
 */
using System;
using System.IO;

class ReplaceAllOccurences
{
    static void Main(string[] args)
    {
        string filename = "..//..//text.txt";
        string newFilename = "..//..//Replaced.txt";
        try
        {
            StreamReader reader = new StreamReader(filename);
            StreamWriter writer = new StreamWriter(newFilename);

            using (reader)
            using (writer)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string newLine = line.Replace("start", "finish");
                    writer.WriteLine(newLine);
                    writer.Flush();
                    line = reader.ReadLine();
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
    }
}
