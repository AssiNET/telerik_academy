using System;
using System.Globalization;
using System.Threading;

class ShowsTheSign
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double a = -0.5d;
        double b = 5.0d;
        double c = -3.4d;

        Console.WriteLine("Numbers: {0}, {1}, {2}", a, b, c);
        Console.WriteLine();

        if (a < 0 && b > 0 && c > 0)
        {
            Console.WriteLine("The product's sign of is : -");
        }
        else if (a < 0 && b > 0 && c < 0)
        {
            Console.WriteLine("The product's sign is : +");
        }
        else if (a > 0 && b > 0 && c > 0)
        {
            Console.WriteLine("The product's sign is : +");
        }
        else if (a < 0 && b < 0 && c < 0)
        {
            Console.WriteLine("The product's sign is : -");
        }
        else if (a < 0 && b < 0 && c > 0)
        {
            Console.WriteLine("The product's sign is : +");
        }
        else if (a > 0 && b < 0 && c < 0)
        {
            Console.WriteLine("The product's sign is : +");
        }
        else if (a > 0 && b < 0 && c > 0)
        {
            Console.WriteLine("The product's sign is : -");
        }
        else if (a > 0 && b > 0 && c < 0)
        {
            Console.WriteLine("The product's sign is : -");
        }
    }
}

