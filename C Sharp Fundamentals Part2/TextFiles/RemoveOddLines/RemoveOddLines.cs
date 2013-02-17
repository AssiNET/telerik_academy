/*
 * Write a program that deletes from given text file all odd lines. 
 * The result should be in the same file.
 */
using System;
using System.IO;
using System.Text;

class RemoveOddLines
{
    static void Main(string[] args)
    {
        string filename = "..//..//WithLineNumbers.txt";
        string newFilename = "..//..//temp.txt";
        
        try
        {
            StreamReader reader = new StreamReader(filename);
            StreamWriter writer = new StreamWriter(newFilename);
            
            using (reader)
            using (writer)
            {
                string line = reader.ReadLine();
                int counter = 1;

                while (line != null)
                {
                    if (counter % 2 == 0)
                    {
                        writer.WriteLine(line);
                        writer.Flush();
                    }
                    counter++;
                    line = reader.ReadLine();
                }
            }
            File.Delete(filename);
            File.Copy(newFilename, filename);
            File.Delete(newFilename);
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