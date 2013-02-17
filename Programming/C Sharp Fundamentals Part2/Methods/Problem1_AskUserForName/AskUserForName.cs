/*
 * Write a method that asks the user for his name and 
 * prints “Hello, <name>” (for example, “Hello, 
 * Peter!”). Write a program to test this method.
 */

using System;

namespace Problem1_AskUserForName
{
    public class AskUserForName
    {
        public static bool ValidateName(string input)
        {
            bool isValid = true;                        // Set the name for valid

            if (input.Length > 2)                       // Check for the length of the name
            {
                foreach (char ch in input)
                {
                    if (!char.IsLetter(ch))             // Check if all character are alphabetic
                    {
                        isValid = false;
                    }
                }
            }
            else                                        // If the length is equal or less than 2 characters it's not valid name
            {
                isValid = false;
            }
            return isValid;
        }

        public static string AskForName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            if (ValidateName(name))
            {
                return Print(name);    
            }
            return"This is not a valid name!";
        }

        public static string Print(string name)
        {
            return "Hello, " + name + "!";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(AskForName());
        }
    }
}
