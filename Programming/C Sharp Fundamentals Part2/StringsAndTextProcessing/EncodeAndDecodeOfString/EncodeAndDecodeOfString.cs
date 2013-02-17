/*
 * Write a program that encodes and decodes a string using given encryption key (cipher). 
 * The key consists of a sequence of characters. The encoding/decoding is done by 
 * performing XOR (exclusive or) operation over the first letter of the string with the 
 * first of the key, the second – with the second, etc. When the last key character is 
 * reached, the next is the first.
 */

using System;
using System.IO;
using System.Text;

class EncodeAndDecodeOfString
{
    static void Main(string[] args)
    {
        try
        {
            string text = "Nakov";
            string cipher = "ab";

            string encodedText = Encode(text, cipher);

            foreach (char ch in encodedText.ToString())
            {
                Console.Write(@"\u{0:x4}", (ushort)ch);
            }
            Console.WriteLine();

            Console.WriteLine(Decode(encodedText, cipher));
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
        catch(IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
    }

    static string Decode(string encodedText, string cipher)
    {
        string text = Encode(encodedText, cipher);

        return text;
    }

    static string Encode(string text, string cipher)
    {
        if (text.Equals(null) || text.Length == 0)
        {
            throw new ArgumentException("Text is missing!!!");
        }

        if (cipher.Equals(null) || cipher.Length == 0)
        {
            throw new ArgumentException("Cipher is missing!!!");
        }

        StringBuilder encodedText = new StringBuilder();

        for (int letterIndex = 0; letterIndex < text.Length; letterIndex++)
        {
            encodedText.Append((char)(text[letterIndex] ^ cipher[letterIndex % cipher.Length]));
        }

        return encodedText.ToString();
    }
}