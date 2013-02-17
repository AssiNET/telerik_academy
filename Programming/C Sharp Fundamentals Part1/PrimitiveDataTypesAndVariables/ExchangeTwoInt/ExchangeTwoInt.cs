using System;

class ExchangeTwoInt
{
    static void Main()
    {
        int intNumber1 = 5;
        int intNumber2 = 10;
        int temp = 0;

        Console.WriteLine("intNumber1: {0}", intNumber1);
        Console.WriteLine("intNumber2: {0}", intNumber2);
        Console.WriteLine();

        temp = intNumber1;
        intNumber1 = intNumber2;
        intNumber2 = temp;

        Console.WriteLine("After exchange...");
        Console.WriteLine();
        Console.WriteLine("intNumber1: {0}", intNumber1);
        Console.WriteLine("intNumber2: {0}", intNumber2);
        
    }
}

