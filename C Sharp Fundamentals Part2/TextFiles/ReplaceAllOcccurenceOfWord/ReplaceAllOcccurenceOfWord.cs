/*
 * Modify the solution of the previous problem to replace
 * only whole words (not substrings).
 */

using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceAllOcccurenceOfWord
{
    static void Main(string[] args)
    {
        string pattern = @"\bstart\b";      //Match words in format ('start ', ', start', ' start', ' start ', 'start.', ' start,')
        string replacement = "finish";
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
                    string newLine = Regex.Replace(line, pattern, replacement);   
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
