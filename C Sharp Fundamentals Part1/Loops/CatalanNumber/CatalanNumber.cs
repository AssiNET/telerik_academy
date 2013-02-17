using System;
using System.Numerics;

class CatalanNumber
{
    static void Main()
    {
        uint n = 0;

        while (true)
        {
            Console.Write("Enter number for n: ");
            if (uint.TryParse(Console.ReadLine(), out n))
            {
                break;
            }
            else
            {
                Console.WriteLine("Wrong input!!!");
            }
        }

        BigInteger catalanNumber = 1;
        for (int i = 0; i < n; i++)
        {
            catalanNumber = (2 * (2 * i + 1) * catalanNumber) / (i + 2);
        }
        Console.WriteLine(catalanNumber);
    }
}

