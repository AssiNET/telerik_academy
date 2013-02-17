using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        int x = 0;
        int y = 0;

        while (true)
        {
            Console.Write("Enter value for x: ");
            if (int.TryParse(Console.ReadLine(), out x))
            {
                break;
            }
            else
            {
                Console.WriteLine("Wrong input!!!");
            }
        }

        while (true)
        {
            Console.Write("Enter value for y > x: ");
            if (int.TryParse(Console.ReadLine(), out y) && y < x)
            {
                break;
            }
            else
            {
                Console.WriteLine("Wrong input!!!");
            }
        }

        int remainder = x % y;
        while (remainder != 0)
        {
            x = y;
            y = remainder;
            remainder = x % y;
        }
        Console.WriteLine(y);
    }
}

