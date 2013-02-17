using System;

class TheGreatestOfFive
{
    static void Main()
    {
        int a = 5;
        int b = 3;
        int c = 6;
        int d = 1;
        int e = 2;

        Console.WriteLine("{0}, {1}, {2}, {3}, {4}", a, b, c, d, e);
        int biggest = a;

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
        else if (d > biggest)
        {
            biggest = d;
        }
        else if (e > biggest)
        {
            biggest = e;
        }
        Console.WriteLine(biggest);
    }
}

