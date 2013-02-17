/*
 * Write a program that extracts from given HTML file its title (if available), 
 * and its body text without the HTML tags. 
 * Example:
 *      <html>
 *          <head><title>News</title></head>
 *          <body><p><a href="http://academy.telerik.com">Telerik
 *                   Academy</a>aims to provide free real-world practical
 *                   training for young people who want to turn into
 *                   skillful .NET software engineers.</p></body>
 *      </html>
 */

using System;
using System.IO;
using System.Text;

class HtmlFile
{
    static void Main(string[] args)
    {
        try
        {
            StreamReader reader = new StreamReader("..//..//text.html");
            StringBuilder text = new StringBuilder();

            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    text.AppendLine(line);
                    line = reader.ReadLine();
                }
            }

            ReadHtmlContent(text);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
        catch (FileNotFoundException fne)
        {
            Console.WriteLine(fne.Message);
        }
        catch (DirectoryNotFoundException dne)
        {
            Console.WriteLine(dne.Message);
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
    }
  
    static void ReadHtmlContent(StringBuilder text)
    {
        bool isTagOpened = true;
        StringBuilder htmlContent = new StringBuilder();

        for (int i = 0; i < text.Length - 1; i++)
        {
            if (!isTagOpened)
            {
                htmlContent.Append(text[i]);
            }

            if (text[i] == '>' && text[i + 1] == '<')
            {
                isTagOpened = true;
            }
            else if (text[i] == '>' && char.IsLetterOrDigit(text[i + 1]))
            {
                isTagOpened = false;
                htmlContent.Append(" ");
            }
            else if (char.IsLetterOrDigit(text[i]) && text[i + 1] == '<' || char.IsPunctuation(text[i]) && text[i + 1] == '<')
            {
                isTagOpened = true;
            }
        }
        Console.WriteLine(htmlContent);
    }
}