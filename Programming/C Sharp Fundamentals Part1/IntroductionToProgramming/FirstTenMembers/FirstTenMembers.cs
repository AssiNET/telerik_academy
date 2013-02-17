using System;

class FirstTenMembers
{
    static void Main()
    {
        for (byte number = 2; number < 100; number++)
        {
            if (number > 10)
            {
                break;
            }
            else if (number % 2 == 0)
            {
                Console.Write(number);
            }
            else if (number % 2 > 0)
            {
                Console.Write(-number);
            }

            if (number < 10)
            {
                Console.Write("," + " ");    
            }
            
        }
        Console.WriteLine();
    }
}