using System;

class PrintFromOneToN
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
            Console.Write("{0, 7}", number);

            if (number % 10 == 0)
            {
                Console.WriteLine(); 
            }
        }
    }
}
