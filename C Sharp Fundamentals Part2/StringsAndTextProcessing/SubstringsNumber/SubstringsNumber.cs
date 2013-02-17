/*
 * Write a program that finds how many times a substring is contained 
 * in a given text (perform case insensitive search).
 * 
 * Example: The target substring is "in". The text is as follows:
 *      We are living in an yellow submarine. We don't 
 *      have anything else. Inside the submarine is very 
 *      tight. So we are drinking all the day. We will 
 *      move out of it in 5 days.
 *      
 * The result is: 9.
 */

using System;

class SubstringsNumber
{
    static void Main()
    {
        string str = "We are living in an yellow submarine. We don't " + 
                     "have anything else. Inside the submarine is very " + 
                     "tight. So we are drinking all the day. We will " + 
                     "move out of it in 5 days.";
        string subStr = "in";
        string strToLower = str.ToLower();
        int occurence = 0;
        int index = strToLower.IndexOf("in");

        if (index == -1)
        {
            Console.WriteLine("There isn't substring \"{0}\" in the string!", subStr);
        }

        while (index != -1)
        {
            occurence++;
            index = strToLower.IndexOf("in", index + 1);
            
        }
        Console.WriteLine(occurence);
    }
}