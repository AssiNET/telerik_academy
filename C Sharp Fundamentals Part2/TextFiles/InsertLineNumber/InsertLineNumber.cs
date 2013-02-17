/*
 * Write a program that reads a text file and inserts line numbers 
 * in front of each of its lines. The result should be written to 
 * another text file.
 */

using System;
using System.IO;

class InsertLineNumber
{
    static void Main(string[] args)
    {
        ReadWrite("..//..//text.txt", "..//..//WithLineNumbers.txt");
    }

    static void ReadWrite(string readFrom, string writeTo)
    {
        try
        {
            StreamReader reader = new StreamReader(readFrom);
            using (reader)
            {
                StreamWriter writer = new StreamWriter(writeTo);
                string line = reader.ReadLine();
                using (writer)
                {
                    int lineNum = 1;
                    while (line != null)
                    {
                        writer.WriteLine("Line {0}: {1}", lineNum, line);
                        writer.Flush();
                        lineNum++;
                        line = reader.ReadLine();
                    }
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
