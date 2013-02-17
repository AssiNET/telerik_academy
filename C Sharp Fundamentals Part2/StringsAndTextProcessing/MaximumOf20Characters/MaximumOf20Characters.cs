/*
 * Write a program that reads from the console a string of maximum 20 characters. 
 * If the length of the string is less than 20, the rest of the characters should 
 * be filled with '*'. Print the result string into the console.
 */

using System;
using System.IO;

class MaximumOf20Characters
{
    static void Main(string[] args)
    {
        string str = null;
        try
        {
            do
            {
                Console.Write("Please fill string with maximum length of 20 characters: ");
                str = Console.ReadLine();
            }
            while (str.Length > 20);

            if (str.Length < 20)
            {
                Console.WriteLine(str.PadRight(20, '*'));
            }
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
        catch (OutOfMemoryException ofm)
        {
            Console.WriteLine(ofm.Message);
        }
        catch (ArgumentOutOfRangeException are)
        {
            Console.WriteLine(are.Message);
        }
    }
}