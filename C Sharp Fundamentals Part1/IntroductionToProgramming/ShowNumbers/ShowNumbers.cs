using System;

class ShowNumbers
{
    static void Main()
    {
        for (byte number = 1; number <= 9; number+=4)
        {
            Console.Write(Convert.ToString(number, 2) + " ");
        }
        Console.WriteLine();
    }
}

