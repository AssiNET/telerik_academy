/*
 * Write a program to check if in a given expression the brackets are put correctly.
 * Example of correct expression: ((a+b)/5-d).
 * Example of incorrect expression: )(a+b)).
 */

using System;

class BracketsInExpression
{
    static void Main(string[] args)
    {
        //string expression = ")(a+b)";
        //string expression = "((a+b)/5-d)";

        string expression = Console.ReadLine();
        int bracketsNum = 0;

        foreach (var ch in expression)
        {
            if (ch == '(')
            {
                bracketsNum++;        
            }
            else if (ch == ')')
            {
                bracketsNum--;
            }

            if (bracketsNum < 0)
            {
                Console.WriteLine("Brackets in the expression - {0} are not correct", expression);
                break;
            }
        }

        if (bracketsNum == 0)
        {
            Console.WriteLine("Brackets in the expression - {0} are correct", expression);
        }
        else
        {
            Console.WriteLine("Brackets in the expression - {0} are not correct", expression);
        }
    }
}