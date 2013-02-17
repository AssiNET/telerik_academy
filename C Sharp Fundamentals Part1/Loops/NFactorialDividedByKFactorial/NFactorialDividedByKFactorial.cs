using System;
using System.Numerics;

class NFactorialDividedByKFactorial
{
    static void Main()
    {
        uint n = 0u;
        uint k = 0u;

        while (true)
        {
            Console.Write("Enter positive value for K: ");
            if (uint.TryParse(Console.ReadLine(), out k) && k > 1)
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
            Console.Write("Enter positive value for N > K: ");
            if (uint.TryParse(Console.ReadLine(), out n) && n > k)
            {
                break;
            }
            else
            {
                Console.WriteLine("Wrong input!!!");
            }
        }

        BigInteger result = 1;
        for (ulong i = k + 1; i <= n; i++)
        {
            result *= i;
        }

        Console.WriteLine("N! / K! = {0}", result);
    }
}

