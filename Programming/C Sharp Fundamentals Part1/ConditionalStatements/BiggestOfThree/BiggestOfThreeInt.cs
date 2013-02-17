using System;

class BiggestOfThreeInt
{
    static void Main()
    {
        int a = 24;
        int b = 24;
        int c = 24;
        
        Console.WriteLine("a = {0} \nb = {1} \nc = {2}", a, b, c);

        if (a != b && b != c && a != c)
        {
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine(a);
                }
                else if (a < c)
                {
                    Console.WriteLine(c);
                }
            }
            else if (a < b)
            {
                if (b > c)
                {
                    Console.WriteLine(b);
                }
                else if (b < c)
                {
                    Console.WriteLine(c);
                }
            }
        }
        else if (a == b)
        {
            if (a > c)
            {
                Console.WriteLine(a);
            }
            else if (a < c)
            {
                Console.WriteLine(c);
            }
            else if (a == c)
            {
                Console.WriteLine("a == b == c");
            }
        }
        else if (a == c)
        {
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else if (a < b)
            {
                Console.WriteLine(b);
            }
        }
        else if (b == c)
        {
            if (b > a)
            {
                Console.WriteLine(b);
            }
            else if (b < a)
            {
                Console.WriteLine(a);
            }
        }
    }
}