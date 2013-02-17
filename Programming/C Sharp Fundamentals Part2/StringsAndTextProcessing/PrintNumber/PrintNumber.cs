/*
 * Write a program that reads a number and prints it as a decimal number, 
 * hexadecimal number, percentage and in scientific notation. Format the 
 * output aligned right in 15 symbols.
 */

using System;
using System.IO;

class PrintNumber
{
    static void Main(string[] args)
    {

        int number = int.Parse(Console.ReadLine());

        try
        {
            Console.WriteLine("{0,15:D}", number);
            Console.WriteLine("{0,15:X}", number);
            Console.WriteLine("{0,15:P}", number);
            Console.WriteLine("{0,15:E}", number);
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
