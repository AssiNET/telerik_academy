/*
 * Write a program that downloads a file from Internet 
 * (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and 
 * stores it the current directory. Find in Google how
 * to download files in C#. Be sure to catch all 
 * exceptions and to free any used resources in the finally block.
 */

using System;
using System.Net;

class DownloadFile
{
    static void Main(string[] args)
    {
        string url = "http://www.devbg.org/img/Logo-BASD.jpg";
        string downloadDir = "..//..//Logo-BASD.jpg";

        Download(url, downloadDir);
    }
  
    static void Download(string url, string downloadDir)
    {
        try
        {
            WebClient client = new WebClient();

            using (client)
            {
                client.DownloadFile(url, downloadDir);
            }            

            Console.WriteLine("The file was successfully downloaded!!!");
        }
        catch (ArgumentNullException)
        {
            Console.Error.WriteLine("Missing url or download directory!!!");
        }
        catch (WebException)
        {
            Console.Error.WriteLine("You have entered a wrong url or you have not set a name for the file!!!");
        }
        catch (NotSupportedException)
        {
            Console.Error.WriteLine("The application can not download the file!!!");
        }
    }
}