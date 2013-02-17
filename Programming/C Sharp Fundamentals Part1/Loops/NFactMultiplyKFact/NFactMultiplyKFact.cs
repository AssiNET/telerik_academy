using System;
using System.Numerics;

class NFactMultiplyKFact
{
    static void Main()
    {
        uint n = 0u;
        uint k = 0u;

        while (true)
        {
            Console.Write("Enter positive value for N: ");
            if (uint.TryParse(Console.ReadLine(), out n) && n > 1)
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
            Console.Write("Enter positive value for K > N: ");
            if (uint.TryParse(Console.ReadLine(), out k) && k > n)
            {
                break;
            }
            else
            {
                Console.WriteLine("Wrong input!!!");
            }
        }

        BigInteger result = 1;
        
        for (ulong i = 1, j = (k - n) + 1; i <= k; i++, j++)
        {
            if (i <= n)
            {
                result *= i;    
            }
            if (j <= k)
            {
                result *= j;
            }
        }

        Console.WriteLine("N! * K! / (K - N)! = {0}", result);
    }
}

