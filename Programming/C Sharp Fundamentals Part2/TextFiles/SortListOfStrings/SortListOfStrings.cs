/*
 * Write a program that reads a text file containing a list of strings, 
 * sorts them and saves them to another text file. 
 * Example:
	        Ivan			George
	        Peter			Ivan
	        Maria			Maria
	        George			Peter
 */

using System;
using System.Collections.Generic;
using System.IO;

class SortListOfStrings
{
    static void Main(string[] args)
    {
        string filename = "..//..//strings.txt";

        List<string> strings = ReadFile(filename);

        WriteFile(strings, "..//..//SortedStrings.txt");
    }

    static void WriteFile(List<string> strings, string filename)
    {
        try
        {
            StreamWriter writer = new StreamWriter(filename);
            using (writer)
            {
                foreach (var str in strings)
                {

                    writer.WriteLine(str);
                    writer.Flush();
                }
            }
        }
        catch (FileNotFoundException fe)
        {
            Console.WriteLine(fe.Message);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
        catch (OutOfMemoryException ofm)
        {
            Console.WriteLine(ofm.Message);
        }
    }

    static List<string> ReadFile(string filename)
    {
        List<string> strings = new List<string>();

        try
        {
            StreamReader reader = new StreamReader(filename);
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    strings.Add(line);
                    line = reader.ReadLine();
                }
            }
            strings.Sort();
        }
        catch (FileNotFoundException fe)
        {
            Console.WriteLine(fe.Message);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
        catch (OutOfMemoryException ofm)
        {
            Console.WriteLine(ofm.Message);
        }
        return strings;
    }
}
