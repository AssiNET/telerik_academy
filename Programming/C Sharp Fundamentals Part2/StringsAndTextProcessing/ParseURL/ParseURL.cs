/*
 * Write a program that parses an URL address given in the format:
 *      [protocol]://[server]/[resource]
 *      
 * and extracts from it the [protocol], [server] and [resource] elements. 
 * For example from the URL http://www.devbg.org/forum/index.php the 
 * following information should be extracted:
		[protocol] = "http"
		[server] = "www.devbg.org"
		[resource] = "/forum/index.php"
 */

using System;
using System.Text.RegularExpressions;

class ParseURL
{
    static void Main(string[] args)
    {
        string url = "http://www.devbg.org/forum/index.php";

        try
        {
            MatchCollection urlElements = Regex.Matches(url, "(.*)://(.*?)(/.*)");

            foreach (Match element in urlElements)
            {
                Console.WriteLine("protocol = \"{0}\"\nserver = \"{1}\"\nresource = \"{2}\"\n", element.Groups[1], element.Groups[2], element.Groups[3]);
            }
        }
        catch (RegexMatchTimeoutException rme)
        {
            Console.WriteLine(rme.Message);
        }
        catch (ArgumentNullException ane)
        {
            Console.WriteLine(ane.Message);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}