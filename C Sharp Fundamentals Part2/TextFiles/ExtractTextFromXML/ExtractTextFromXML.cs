/*
 * Write a program that extracts from given XML file all the text 
 * without the tags. Example:
        <?xml version="1.0"><student><name>Pesho</name>
 *      <age>21</age><interests count="3"><interest> Games</instrest>
 *      <interest>C#</instrest><interest> Java</instrest></interests></student>

 */

using System;
using System.IO;
using System.Text.RegularExpressions;

class ExtractTextFromXML
{
    static void Main(string[] args)
    {
        string filename = "..//..//user.xml";
        string pattern = ">(?<content>.*)</";
        try
        {
            StreamReader reader = new StreamReader(filename);
            Regex regex = new Regex(pattern);

            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    Match match = regex.Match(line);
                    while (match.Success)
                    {
                        Console.WriteLine(match.Groups["content"]);
                        match = match.NextMatch();
                    }
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
        catch (OutOfMemoryException om)
        {
            Console.WriteLine(om.Message);
        }
    }
}
