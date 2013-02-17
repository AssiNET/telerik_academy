/*
 * Write a program that reads a string, reverses it and prints the result at the console.
 * Example: "sample" -> "elpmas".
 */

using System;
using System.Text;

class ReadsAndReverse
{
    static void Main()
    {
        string str = Console.ReadLine();
        StringBuilder reversedStr = new StringBuilder();

        for (int i = str.Length - 1; i >= 0; i--)
        {
            reversedStr.Append(str[i]);    
        }

        Console.WriteLine(reversedStr.ToString());
    }
}

