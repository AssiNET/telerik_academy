/*
 * Write a program that converts a string to a sequence of C# Unicode
 * character literals. Use format strings. 
 *      Sample input: Hi!
        Expected output:
            \u0048\u0069\u0021
 */

using System;
using System.IO;

class StringToUnicodeLiteral
{
    static void Main(string[] args)
    {
        string input = "Hi!";

        try
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write("\\u{0:x4}", (ushort)input[i]);
            }
            Console.WriteLine();
        }
        catch (ArgumentNullException ane)
        {
            Console.WriteLine(ane.Message);
        }
        catch (FormatException fe)
        {
            Console.WriteLine(fe.Message);
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
        
    }
}