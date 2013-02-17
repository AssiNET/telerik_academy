using System;
using System.Globalization;
using System.Threading;

class UserInputChoice
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter integer, double or string value: ");
        string input = Console.ReadLine();
        double doubleValue = 0.0d;

        if (double.TryParse(input, out doubleValue))
        {
            doubleValue++;
            Console.WriteLine(doubleValue);
        }
        else
        {
            Console.WriteLine(input + "*");
        }
    }
}

