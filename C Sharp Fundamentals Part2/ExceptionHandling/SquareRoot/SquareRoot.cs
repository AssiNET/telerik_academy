/*
 * Write a program that reads an integer number and calculates
 * and prints its square root. If the number is invalid or 
 * negative, print "Invalid number". In all cases finally print 
 * "Good bye". Use try-catch-finally.
 */

using System;

class SquareRoot
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        double sqrt = 0d;
        try
        {
            sqrt = GetSqrt(input);
            Console.WriteLine(sqrt);
        }
        catch (FormatException fe)
        {

            Console.WriteLine(fe.Message);
        }
        catch(ArgumentException ae)
        {
            Console.WriteLine(ae.Message);    
        }
        finally
        {
            Console.WriteLine("Good bye!!!");
        }
    }

    static double GetSqrt(string input)
    {
        foreach (var ch in input)
        {
            if (char.IsLetter(ch))
            {
                throw new FormatException("Your input is not numerical!");
            }
        }

        double num = double.Parse(input);

        if (num < 0)
        {
            throw new ArgumentException("You have entered a negative number!");
        }

        return Math.Sqrt(num);
    }
}
