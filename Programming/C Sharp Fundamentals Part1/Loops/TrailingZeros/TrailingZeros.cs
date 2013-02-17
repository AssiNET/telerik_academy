using System;
using System.Numerics;

class TrailingZeros
{
    static void Main()
    {
        ulong n = 10u; //50000
        BigInteger factorial = 1;
        ulong numberZeros = 0u;
        ulong divider = 1u;

        Console.WriteLine("For N = {0}", n);
        for (uint i = 1; i <= n; i++)
        {
            //factorial *= i;
            divider *= 5;
            numberZeros += n / divider;
        }

        /* Another way of finding how many trailing zeros exist in N!, but you have to calculate
         * the value of N!. That's why it's much slower for great values like 50000 or 100000 of N  */
        //Console.WriteLine("At the end of the N! = {0}", factorial);
        //while (factorial % 10 == 0)
        //{
        //    numberZeros++;
        //    factorial /= 10;
        //}
        
        Console.WriteLine("There is {0} trailing zeros.", numberZeros);
    }
}

