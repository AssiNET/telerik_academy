using System;

class CheckIsDividable
{
    static void Main()
    {
        int number = 30;

        Console.WriteLine((number % 5 == 0) && (number % 7 == 0));
        //Console.WriteLine((number % 35 == 0));
    }
}
