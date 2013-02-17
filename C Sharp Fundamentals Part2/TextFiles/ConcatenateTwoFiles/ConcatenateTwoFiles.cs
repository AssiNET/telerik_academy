/*
 * Write a program that concatenates two text files into another text file.
 */
using System;
using System.IO;

class ConcatenateTwoFiles
{
    static void Main(string[] args)
    {
        ReadWrite("..//..//FirstFile.txt", "..//..//ConcatFile.txt", false);
        ReadWrite("..//..//SecondFile.txt", "..//..//ConcatFile.txt", true);
    }
  
    static void ReadWrite(string readFrom, string writeTo, bool isAppend)
    {
        try
        {
            StreamReader reader = new StreamReader(readFrom);
            using (reader)
            {
                StreamWriter writer = new StreamWriter(writeTo, isAppend);
                string line = reader.ReadLine();
                using (writer)
                {
                    while (line != null)
                    {
                        writer.WriteLine(line);
                        writer.Flush();
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
