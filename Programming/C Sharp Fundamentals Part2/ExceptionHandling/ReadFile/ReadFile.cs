/*
 * Write a program that enters file name along with its full 
 * file path (e.g. C:\WINDOWS\win.ini), reads its contents 
 * and prints it on the console. Find in MSDN how to use 
 * System.IO.File.ReadAllText(…). Be sure to catch all possible
 * exceptions and print user-friendly error messages.
 */

using System;
using System.IO;

class ReadFile
{
    static void Main(string[] args)
    {
        Console.WriteLine(ReadWholeFile("..\\..\\text.txt"));
        Console.WriteLine(Read("..\\..\\text.txt"));
    }

    static string Read(string filename)
    {
        string content = null;
        
        try
        {
            content = File.ReadAllText(filename);
        }
        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine("File is not found!!!");
        }
        catch (DirectoryNotFoundException dnfe)
        {
            Console.WriteLine("There is no such directory!!!");
        }
        catch (IOException ioe)
        {
            Console.WriteLine("The application can not open the file!!!");
        }
        
        return content;
    }

    static string ReadWholeFile(string filename)
    {
        string content = null;
        try
        {
            StreamReader reader = new StreamReader(filename);
            using (reader)
            {
                content = reader.ReadToEnd();
            }
        }
        catch (FileNotFoundException fnfe)
        {
            Console.Error.WriteLine("File is not found!!!");
        }
        catch (DirectoryNotFoundException dnfe)
        {
            Console.Error.WriteLine("There is no such directory!!!");
        }
        catch (IOException ioe)
        {
            Console.Error.WriteLine("The application can not open the file!!!");
        }

        return content;
    }
}
