using System;

class NumbersDivisibleByFive
{
    static void Main()
    {
        ulong x = 0u;
        ulong y = 0u;
        ulong count = 0u;

        while (true)
        {
            Console.Write("Enter positive value for 'x': ");
            if (ulong.TryParse(Console.ReadLine(), out x) && x > 0)
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
            Console.Write("Enter positive value for 'y': ");
            if (ulong.TryParse(Console.ReadLine(), out y) && y > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Wrong input!!!");
            }
        }
        //-----------Count how many number are divisible by 5 and the remainder is 0-----------
        count = Math.Max(x, y) / 5 - Math.Min(x, y) / 5;
        if ((x % 5 == 0 && y % 5 == 0) || (Math.Min(x, y) % 5 == 0 && Math.Max(x, y) % 5 != 0)) 
        {
            count++;
        }
        //-------------------------------------------------------------------------------------
        Console.Write("There is {0} numbers divisible by 5 with remainder equal to 0, ", count);
        Console.WriteLine("in the interval [{0}, {1}]", x, y);
    }
}

