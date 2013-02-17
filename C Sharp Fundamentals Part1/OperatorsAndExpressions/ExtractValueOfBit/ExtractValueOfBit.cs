using System;

class ExtractValueOfBit
{
    static void Main()
    {
        int i = 5;
        int b = 2;
        int mask = 1 << b;
        int bitwiseAnd = i & mask;
        int bit = bitwiseAnd >> b;

        Console.WriteLine("5 = {0}", Convert.ToString(i, 2).PadLeft(32, '0'));
        Console.WriteLine("The value of bit at p = {0} is {1} ", b, bit);
    }
}

