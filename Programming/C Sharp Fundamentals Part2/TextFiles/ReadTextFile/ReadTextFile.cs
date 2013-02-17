/*
 * Write a program that reads a text file and prints on the console its odd lines.
 */
using System;
using System.IO;

class ReadTextFile
{
    static void Main(string[] args)
    {
        string filepath = "..//..//text.txt";

        ReadOddLines(filepath);
    }
  
    static void ReadOddLines(string filepath)
    {
        StreamReader reader = new StreamReader(filepath);
        using (reader)
        {
            int counter = 1;
            string line = reader.ReadLine();
            while (line != null)
            {
                if (counter % 2 != 0)
                {
                    Console.WriteLine(line);    
                }
                counter++;
                line = reader.ReadLine();
            }
        }
    }
}
