/*
 * Write a method ReadNumber(int start, int end) that enters 
 * an integer number in given range [start…end]. If an invalid 
 * number or non-number text is entered, the method should 
 * throw an exception. Using this method write a program that 
 * enters 10 numbers:
			a1, a2, … a10, such that 1 < a1 < … < a10 < 100
 */

using System;

class Print10Numbers
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            try
            {
                ReadNumber(1, 100);                         // parameters are meant to be the range in which you have to enter an integer value
            }
            catch (ArgumentOutOfRangeException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
        }
    }

    static int ReadNumber(int start, int end)
    {
        int num = 0;
        if (!int.TryParse(Console.ReadLine(), out num))
        {
            throw new FormatException();
        }

        if ((num < start && num < end) || (num > start && num > end))
        {
            throw new ArgumentOutOfRangeException();
        }
        return num;
    }
}