using System;

class PrintNotDivisible
{
    static void Main()
    {
        ulong n = 0u;
        while (true)
        {
            if (ulong.TryParse(Console.ReadLine(), out n))
            {
                break;
            }
            else
            {
                Console.WriteLine("Wrong input!!!");
            }
        }

        for (ulong number = 1; number <= n; number++)
        {
            if ( (number % 3 == 0) && (number % 7 == 0) )
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine();
    }
}
