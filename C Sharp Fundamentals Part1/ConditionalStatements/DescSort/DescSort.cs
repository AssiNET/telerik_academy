using System;

class DescSort
{
    static void Main()
    {
        int a = 8;
        int b = 6;
        int c = 7;
        int biggest = 0;
        
        biggest = a;
        
        if (a > biggest)
        {
            biggest = a;
        }
        else if (b > biggest)
        {
            biggest = b;
        }
        else if (c > biggest)
        {
            biggest = c;
        }

        Console.Write(biggest + " ");

        if (biggest > a && biggest > b)
        {
            if (a > b)
            {
                Console.WriteLine(a + " " + b);
            }
            else if (a < b)
            {
                Console.WriteLine(b + " " + a);
            }
        }
        else if (biggest > a && biggest > c)
        {
            if (a > c)
            {
                Console.WriteLine(a + " " + c);
            }
            else if (a < c)
            {
                Console.WriteLine(c + " " + a);
            }
        }
        else if (biggest > b && biggest > c)
        {
            if (b > c)
            {
                Console.WriteLine(b + " " + c);
            }
            else if (b < c)
            {
                Console.WriteLine(c + " " + b);
            }
        }
    }
}

